//Автор(с): Кудуштеев Алексей
package serverkn;
import java.util.*;
import java.net.*;
import java.io.*;
import java.util.Hashtable;
import java.util.concurrent.atomic.AtomicInteger;
import java.util.concurrent.locks.ReadWriteLock;
import java.util.concurrent.locks.ReentrantReadWriteLock;


//пользователи
final class knUsers {
	public final static int SERVER_REG_USER   = 1; //регистрация
	public final static int SERVER_QUIT_USER  = 2; //пользователь покинул игру
	public final static int SERVER_LIST_USERS = 3; //список пользователей
	public final static int SERVER_TO_USER    = 4; //запрос игрока с играть в игру
	public final static int SERVER_ANSWER_USER= 5; //ответ игрока
	public final static int SERVER_GAME       = 6; //игра началась

	public final static int ERR_ALREADY_USER  = 1; //ошибка: пользователь с таким именем существует
	public final static int ERR_GOOD_USER     = 2; //нет ошибки
	public final static int ERR_NOT_USERS     = 3; //пользователей нет
	public final static int ERR_NOT_GAME_USER = 4; //игрок отклонил игру
	public final static int ERR_FINALIZE_USER = 5; //игроk покинул игру
	public final static int ERR_BUSY_USER     = 6; //пользователь занят
	public final static int ERR_NO_GAME       = 7; //пользователь отверг игру
	public final static int SERVER_DISCONNECT = 8; //отключение игрока
	public final static int SERVER_NEW_GAME   = 9; //новая игра
	public final static int SERVER_MESSAGE    = 10; //посылка сообщения

	public final static int      MAX_BUF = 256;
	public final static int       T_MAX  = 128; //максимум 128-пользователей
	public final static long THREAD_LIFE = 1200000L;

	public final static knTUser[]      tusers  = new knTUser[T_MAX];
	public final static ReadWriteLock  rw_lock = new ReentrantReadWriteLock();
	public final static Hashtable<String, knTUser> clients = new Hashtable<String, knTUser>();

	public static void initialize(){
		synchronized(tusers){
			for(int i = 0; i < T_MAX; ++i)
				tusers[i] = null;
		}
	}

	//удаление всех
	public static void removeAll(){
		synchronized(tusers){
			for(int i = 0; i < T_MAX; ++i) {
				if(tusers[i] != null)
					tusers[i].quit();
				tusers[i] = null;
			}
		}

		try {
			rw_lock.writeLock().lock();
			clients.clear();
		} finally {
			rw_lock.writeLock().unlock();
		}
	}

	//добавление пользователя
	public static boolean add(Socket sock){
		boolean ret = false;
		synchronized(tusers) {
			for(int i = 0; i < T_MAX; ++i){
				if(tusers[i] == null){ //если null то добавим новый поток
					try {
						tusers[i] = new knTUser(sock);
						tusers[i].setUserState(knState.USER_HIDE);
						ret = true;
					} catch(IOException e){
						if(tusers[i] != null)
							tusers[i].quit();
						tusers[i] = null;
						e.printStackTrace();
					}
					break;
				} else if(tusers[i].isWait()){//если поток в ожидание, то будем использовать его
					try {
						tusers[i].setTask(sock);
						tusers[i].setUserState(knState.USER_HIDE);
						ret = true;
					} catch(IOException e){
						e.printStackTrace();
					}
					break;
				}
			}
		}
		return ret;
	}

	//проверить потоки которые уже не активны более 20-минут и удалить только один поток
	public static void kill_threads(){
		long mcur = System.currentTimeMillis();
		synchronized(tusers){
			for(int i = 0; i < T_MAX; ++i){
				if((tusers[i] != null) && tusers[i].isWait() && (mcur > (tusers[i].getTime() + THREAD_LIFE))){
					tusers[i].quit();
					tusers[i] = null;
					int n = T_MAX - 1;
					for(int j = i; j < n; ++j)
						tusers[j] = tusers[j + 1];
					break;
				}
			}
		}
	}

	//кол-во пользователей
	public static int count_users(){
		int n = 0;
		try {
			rw_lock.readLock().lock();
			n = clients.size();
		} finally {
			rw_lock.readLock().unlock();
		}
		return n;
	}

	//**********************************************ЛОГИКА ИГРЫ*******************************************

	//получение данных
	public static boolean read_data(knTUser user){
		boolean ret = true;
		switch(user.getParser().getInt("cmd")){
		case knUsers.SERVER_REG_USER:
			ret = on_reg_user(user);
			break;
		case knUsers.SERVER_QUIT_USER:
			kill_threads();
			ret = false;
			break;
		case knUsers.SERVER_LIST_USERS:
			ret = on_list_users(user);
			break;
		case knUsers.SERVER_TO_USER:
			ret = on_user_to_user(user);
			break;
		case knUsers.SERVER_ANSWER_USER:
			ret = on_answer_user(user);
			break;
		case knUsers.SERVER_GAME:
			ret = on_server_game(user);
			break;
		case knUsers.SERVER_DISCONNECT:
			ret = on_server_disconnect(user);
			break;
		case knUsers.SERVER_NEW_GAME:
			ret = on_server_game(user);
			break;
		case knUsers.SERVER_MESSAGE:
			ret = on_server_game(user);
			break;
		}
		return ret;
	}

	//регистрация пользователя
	private static boolean on_reg_user(knTUser user){
		boolean   reg  = false;
		kv_parser pkv  = user.getParser();
		String    name = pkv.getString("name");
		try {
			rw_lock.writeLock().lock();
			if(! clients.containsKey(name)){
				reg = true;
				clients.put(name, user);
				user.setUserName(name);
				user.setUserState(knState.USER_NORMAL);
			}
		} finally {
			rw_lock.writeLock().unlock();
		}

		ByteChars bch = user.getOutputData();
		bch.reset();

		int res = (reg) ? ERR_GOOD_USER : ERR_ALREADY_USER;
		bch.write("{res:", res, '}');
		return user.write(bch);
	}

	//удаление пользователя
	public static void remove_user(String user_name){
		try {
			rw_lock.writeLock().lock();
			clients.remove(user_name);
		} finally {
			rw_lock.writeLock().unlock();
		}
	}

	//список пользоваталей
	private static boolean on_list_users(knTUser user){
		knTUser   ptr;
		ByteChars bch = user.getOutputData();
		bch.reset();

		try {
			rw_lock.readLock().lock();
			int cnt = 0;
			if(clients.size() > 1){
				bch.write("{res:", knUsers.ERR_GOOD_USER, " users:\"");

				Enumeration<knTUser> it = clients.elements();
				while(it.hasMoreElements()) {
					ptr = it.nextElement();
					if((ptr.getUserName().compareTo(user.getUserName()) != 0) && (ptr.getUserState() == knState.USER_NORMAL)){
						bch.write(ptr.getUserName(), ',');
						++cnt;
					}
				}
				it = null;
				bch.write("\"}");
			}

			if(cnt == 0) {
				bch.reset();
				bch.write("{res:", knUsers.ERR_NOT_USERS, '}');
			}
		} finally {
			rw_lock.readLock().unlock();
		}
		return user.write(bch);
	}

	//приглашение с играть в игру
	private static boolean on_user_to_user(knTUser user){
		kv_parser   pkv = user.getParser();
		knTUser to_user = null;
		ByteChars   bch = user.getOutputData();
		boolean     ret = true;

		try {
			rw_lock.readLock().lock();

			to_user = clients.get(pkv.getString("to"));
			if(to_user == null){//игрок покинул игру
				bch.reset();
				bch.write("{res:", ERR_FINALIZE_USER, '}');
				ret = user.write(bch);
			} else {
				
				if(to_user.getUState().getAndSet(knState.USER_BUSY) == knState.USER_NORMAL)
					to_user.write(pkv.getByteChars().getData(), pkv.getFirst(), pkv.getLast());
				else
					ret = false;

				if(! ret){
					bch.reset();
					bch.write("{res:", ERR_BUSY_USER, '}');
					ret = user.write(bch);
				} else
					user.setUserState(knState.USER_BUSY);	
			}
		} finally {
			rw_lock.readLock().unlock();
		}
		return ret;
	}

	//ответ на приглашение
	private static boolean on_answer_user(knTUser user){
		kv_parser   pkv = user.getParser();
		knTUser to_user = null;
		boolean     ret = true;

		try {
			rw_lock.readLock().lock();
			
			to_user = clients.get(pkv.getString("to"));
			if(to_user == null){//игрок покинул игру
				user.setUserState(knState.USER_NORMAL);
				ByteChars bch = user.getOutputData();
				bch.reset();
				bch.write("{cmd:", knUsers.SERVER_ANSWER_USER, " res:", ERR_FINALIZE_USER, '}');
				ret = user.write(bch);
			} else {
				switch(pkv.getInt("res")){
				case ERR_NO_GAME:
					user.setUserState(knState.USER_NORMAL);
					to_user.setUserState(knState.USER_NORMAL);
					break;
				case ERR_GOOD_USER:
					user.setUserState(knState.USER_BUSY);
					break;
				}
				to_user.write(pkv.getByteChars().getData(), pkv.getFirst(), pkv.getLast());
			}
		} finally {
			rw_lock.readLock().unlock();
		}
		return ret;
	}

	//процесс игры
	private static boolean on_server_game(knTUser user){
		kv_parser   pkv = user.getParser();
		knTUser to_user = null;
		boolean     ret = true;
		
		try {
			rw_lock.readLock().lock();

			to_user = clients.get(pkv.getString("to"));
			if(to_user == null){//игрок покинул игру
				ByteChars bch = user.getOutputData();
				bch.reset();
				bch.write("{cmd:", knUsers.SERVER_ANSWER_USER, " res:", ERR_FINALIZE_USER, '}');
				ret = user.write(bch);
				user.setUserState(knState.USER_NORMAL);
			} else
				to_user.write(pkv.getByteChars().getData(), pkv.getFirst(), pkv.getLast());
			
		} finally {
			rw_lock.readLock().unlock();
		}
		return ret;
	}

	//отключение игрока
	private static boolean on_server_disconnect(knTUser user){
		kv_parser   pkv = user.getParser();
		knTUser to_user = null;
		boolean     ret = true;
		
		try {
			rw_lock.readLock().lock();
			
			to_user = clients.get(pkv.getString("to"));
			if(to_user == null)
				ret = true;
			else {
				to_user.setUserState(knState.USER_NORMAL);
				to_user.write(pkv.getByteChars().getData(), pkv.getFirst(), pkv.getLast());			
			}
			
		} finally {
			rw_lock.readLock().unlock();
		}
		user.setUserState(knState.USER_NORMAL);
		return ret;
	}
}


//-----------------------------------------------------------------------------------------------------------------------

//флаги
final class knState {
	public final static int KNT_WAIT   = 1;
	public final static int KNT_ACTIVE = 2;

	public final static int USER_HIDE   = 0;
	public final static int USER_NORMAL = 1;
	public final static int USER_BUSY   = 2;
}

//поток-пользователь
final class knTUser extends Thread {
	private Object        lobj   = null;
	private volatile boolean done= false;
	private AtomicInteger state  = null;
	private String    user_name  = null;
	private Socket         sock  = null;
	private InputStream     sin  = null;
	private OutputStream   sout  = null;
	private AtomicInteger ustate = null;
	private byte[]          buf  = null;
	private kv_parser      parse = null;
	private ByteChars      odata = null;
	private long         timeout = 0L;

	public knTUser(Socket sock_user) throws IOException {
		super();
		done   = false;
		lobj   = new Object();
		state  = new AtomicInteger(knState.KNT_WAIT);
		ustate = new AtomicInteger(knState.USER_HIDE);
		buf    = new byte[knUsers.MAX_BUF];
		parse  = new kv_parser();
		odata  = new ByteChars();

		setTask(sock_user);
		start();
	}

	public void setTask(Socket sock_user) throws IOException {
		sock = sock_user;
		sin  = sock.getInputStream();
		sout = sock.getOutputStream();
		parse.reset();
		user_name = null;

		state.set(knState.KNT_ACTIVE);
		synchronized(lobj){
			lobj.notify();
		}
	}

	public void setUserName(String name){
		user_name = name;
	}

	public String getUserName(){
		return user_name;
	}

	public void setUserState(int _state){
		ustate.set(_state);
	}

	public int getUserState(){
		return ustate.get();
	}
	
	public AtomicInteger getUState(){
		return ustate;
	}

	@Override
	public void run(){
		while(!done){
			if(state.get() == knState.KNT_WAIT){
				try {
					synchronized(lobj){
						lobj.wait();
					}
				} catch(InterruptedException e){}
			}
			on_run();
		}
	}

	//посылка данных
	public boolean write(ByteChars bch){
		boolean ret = true;
		synchronized(sock){
			try {
				sout.write(bch.getData(), 0, bch.getCount());
			} catch(IOException e){
				ret = false;
			}
		}
		return ret;
	}

	//посылка данных
	public boolean write(byte[] buf, int first, int last){
		boolean ret = true;
		synchronized(sock){
			try {
				sout.write(buf, first, last - first);
			} catch(IOException e){
				ret = false;
			}
		}
		return ret;
	}

	//завершение потока
	public void quit(){
		done = true;
		closeUser();
		state.set(0);
		synchronized(lobj){
			lobj.notify();
		}

		try {
			join();
		} catch(InterruptedException e){}
		lobj   = null;
		state  = null;
		buf    = null;
		parse  = null;
		odata  = null;
		ustate = null;
	}

	public boolean isActive(){
		return (state.get() == knState.KNT_ACTIVE);
	}

	public boolean isWait(){
		return (state.get() == knState.KNT_WAIT);
	}

	public long getTime(){
		return timeout;
	}

	private void on_run(){
		int n = 0;
		while(!done){
			try {
				n = sin.read(buf);
			} catch(IOException e){
				break;
			}

			if(n <= 0)
				break;

			//данные пришли
			parse.add(buf, n);
			if(parse.isBlockData()){
				if(! knUsers.read_data(this))
					break;
			}
		}
		closeUser();
	}

	public void closeUser(){
		if(sock == null)
			return;

		synchronized(sock){
			try {
				sock.close();
			} catch(IOException e){}

			if(user_name != null)
				knUsers.remove_user(user_name);
			user_name = null;

			sout = null;
			sin  = null;
			ustate.set(knState.USER_HIDE);
			state.set(knState.KNT_WAIT);
			parse.reset();
		}
		sock    = null;
		timeout = System.currentTimeMillis();
	}

	ByteChars getOutputData(){
		return odata;
	}

	kv_parser getParser(){
		return parse;
	}
}
