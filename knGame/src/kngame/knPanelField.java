//Автор(с): Кудуштеев Алексей
package kngame;
import javax.swing.JPanel;

import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.BasicStroke;
import java.awt.Stroke;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.image.BufferedImage;
import java.awt.event.MouseListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.concurrent.atomic.AtomicInteger;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.Random;

import javax.swing.SwingUtilities;

import java.awt.Cursor;


//...
final class knUtil {
	public static final long      SLEEP_MSEC = 100L;
	public static final AtomicInteger result = new AtomicInteger(0);
	public static final StringBuilder strbuf = new StringBuilder();
}


//для показа диалога приглашения
class knShowDlg implements Runnable {
	private String       remote = null;
	private knPanelField fpanel = null;
	private boolean      result = false;

	public boolean execute(String user, knPanelField panel){
		remote = user;
		fpanel = panel;
		result = false;
		try {
			SwingUtilities.invokeAndWait(this);
		} catch(Exception e){ e.printStackTrace(); }
		return result;
	}

	public void run(){
		if(fpanel.dlg_to.execute(false, remote)){
			result = true;
			fpanel.start_game(remote);
		} else
			result = false;
	}
}


//диалог для показа сообщений от удалённого пользователя
class knErrorDlg implements Runnable {
	private kv_parser parse = null;
	private knForm    mform = null;
	private int      result = 0;

	public void execute(kv_parser pvk, knForm pform, int _res, boolean _wait){
		parse  = pvk;
		mform  = pform;
		result = _res;
		try {
			if(_wait)
				SwingUtilities.invokeAndWait(this);
			else
				SwingUtilities.invokeLater(this);
		} catch(Exception e){ e.printStackTrace(); }
	}

	public void run(){
		switch(result){
		case knPanelField.ERR_NO_GAME: //пользователь отверг игру
			mform.set_state_game(knForm.res.getString("NO_GAME"), Color.RED);
			mform.set_start_game(false);
			knForm.dlg_error.setMsgText(String.format(knForm.res.getString("USER_STOP"), parse.getString("from")), Color.RED);
			knForm.dlg_error.execute(mform.getX(), mform.getY(), mform.getWidth(), mform.getHeight());
			break;
		case knPanelField.ERR_GOOD_USER: //пользователь согласен на игру
			mform.link_remote_user(parse.getString("from"));
			if(parse.getInt("hod") > 0)
				mform.set_state_game(knForm.res.getString("YOU_HOD"), Color.YELLOW);
			else
				mform.set_state_game(knForm.res.getString("NOT_HOD"), Color.GREEN);
			mform.set_start_game(true);
			mform.set_sign(parse.getChar("sign"));
			break;
		case knPanelField.ERR_FINALIZE_USER: //пользователь покинул игру
			knForm.dlg_error.setMsgText(String.format(knForm.res.getString("USER_FINAL"), mform.getRemoteUserName().getText()), Color.YELLOW);
			knForm.dlg_error.execute(mform.getX(), mform.getY(), mform.getWidth(), mform.getHeight());
			mform.hide_remote_user();
			break;
		case knPanelField.SERVER_DISCONNECT:
			knForm.dlg_error.setMsgText(knForm.res.getString("ABORT"), Color.GREEN);
			knForm.dlg_error.execute(mform.getX(), mform.getY(), mform.getWidth(), mform.getHeight());
			mform.hide_remote_user();
			break;
		case knPanelField.SERVER_NEW_GAME:
			if(parse.getInt("hod") > 0)
				mform.set_state_game(knForm.res.getString("YOU_HOD"), Color.YELLOW);
			else
				mform.set_state_game(knForm.res.getString("NOT_HOD"), Color.GREEN);
			break;
		case knPanelField.SERVER_MESSAGE:
			mform.put_message(parse.getString("msg"));
			break;
		}
	}
}


//обновление состояние игры
class knUpdateState implements Runnable {
	public final static int US_DEFAULT = 0;
	public final static int  US_WINNER = 1;
	public final static int  US_ANSWER = 2;
	private knForm  mform = null;
	private String   text = null;
	private int     utype = 0;

	public void setOwner(knForm dlg){
		mform = dlg;
	}

	public void updateState(String str, int _type){
		text  = str;
		utype = _type;
		try {
			if(_type == US_ANSWER)
				SwingUtilities.invokeAndWait(this);
			else
				SwingUtilities.invokeLater(this);
		} catch(Exception e){ e.printStackTrace(); }
	}

	public void run(){
		switch(utype){
		case US_WINNER:
			mform.set_state_game(text, Color.RED);
			mform.update_remote_user_victory();
			break;
		case US_DEFAULT:
			mform.set_state_game(text, Color.YELLOW);
			break;
		case US_ANSWER:
			knForm.dlg_us.success_result();
			break;
		}
	}
}


//панель игровое поле
@SuppressWarnings("serial")
public class knPanelField extends JPanel {
	private final static char CELL_NONE = ' ';
	public final static char  CELL_N    = 'O';
	public final static char  CELL_K    = 'X';

	public final static int SERVER_REG_USER   = 1; //регистрация
	public final static int SERVER_QUIT_USER  = 2; //пользователь покинул игру
	public final static int SERVER_LIST_USERS = 3; //список пользователей
	public final static int SERVER_TO_USER    = 4; //запрос игрока с играть в игру
	public final static int SERVER_ANSWER_USER= 5; //ответ игрока
	public final static int SERVER_GAME       = 6; //игра началась
	public final static int SERVER_USER_NORMAL= 7; //обычное состояние
	public final static int SERVER_DISCONNECT = 8; //отключение игрока
	public final static int SERVER_NEW_GAME   = 9; //новая игра
	public final static int SERVER_MESSAGE    = 10; //посылка сообщения

	public final static int ERR_ALREADY_USER  = 1; //ошибка: пользователь с таким именем существует
	public final static int ERR_GOOD_USER     = 2; //нет ошибки
	public final static int ERR_NOT_USERS     = 3; //пользователей нет
	public final static int ERR_NOT_GAME_USER = 4; //игрок отклонил игру
	public final static int ERR_FINALIZE_USER = 5; //игроk покинул игру
	public final static int ERR_BUSY_USER     = 6; //пользователь занят
	public final static int ERR_NO_GAME       = 7; //пользователь отверг игру

	private final int     N_SIZE  = 3;
	private int         CELL_SIZE = 0;
	private BasicStroke       pen = null;
	private BufferedImage   img_N = null;
	private BufferedImage   img_K = null;
	private final knTCPClient client = new knTCPClient(this);
	private final ByteChars odata = new ByteChars();
	private AtomicInteger   state = new AtomicInteger(SERVER_REG_USER);
	public  knDlgToUser    dlg_to = null;
	private AtomicBoolean  my_hod = new AtomicBoolean(false);
	public  knForm       dlg_main = null;
	private Random        rnd_hod = new Random();
	private knShowDlg    show_dlg = new knShowDlg();
	private knErrorDlg  error_dlg = new knErrorDlg();
	private knUpdateState state_dlg = new knUpdateState();
	private char          my_sign = 0;
	private Color colorK, colorN;
	private int ox_N, oy_N, ox_K, oy_K;
	private volatile char[][] field = new char[N_SIZE][N_SIZE];

	//конструктор
	public knPanelField(knForm dlg, int width, int height) {
		super(false);
		try {
			dlg_main = dlg;
			state_dlg.setOwner(dlg);
			create(width, height);
		} catch(Exception e){}
	}

	//создание окна
	private void create(int width, int height) throws Exception {
		int size  = Math.min(width, height) / 3 * 2;
		CELL_SIZE = size / N_SIZE;
		size = size / CELL_SIZE * CELL_SIZE;
		setPreferredSize(new Dimension(size, size));
		setSize(size, size);
		setBorder(javax.swing.BorderFactory.createLineBorder(Color.DARK_GRAY, 2));
		setLayout(null);

		pen   = new BasicStroke(2.0f);
		img_K = javax.imageio.ImageIO.read(getClass().getResource("data/krest.png"));
		ox_K  = (CELL_SIZE - img_K.getWidth(null))  / 2;
		oy_K  = (CELL_SIZE - img_K.getHeight(null)) / 2;

		img_N = javax.imageio.ImageIO.read(getClass().getResource("data/null.png"));
		ox_N  = (CELL_SIZE - img_N.getWidth(null))  / 2;
		oy_N  = (CELL_SIZE - img_N.getHeight(null)) / 2;

		colorK = new Color(img_K.getRGB(0, 0));
		colorN = new Color(img_N.getRGB(0, 0));

		reset();
		MouseListener mk = new MouseAdapter() {
			public void mousePressed(MouseEvent e){
				knPanelField.this.mouse_down(e);
			}
		};
		addMouseListener(mk);

		setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
	}

	//обработка щелчка мыши
	private void mouse_down(MouseEvent e){
		int x = e.getX() / CELL_SIZE;
		int y = e.getY() / CELL_SIZE;
		if(x >= N_SIZE)
			x = N_SIZE - 1;
		if(y >= N_SIZE)
			y = N_SIZE - 1;

		if(my_hod.get() && (field[y][x] == CELL_NONE)){
			my_hod.set(false);
			field[y][x] = my_sign;
			repaint(x * CELL_SIZE, y * CELL_SIZE, CELL_SIZE + 1, CELL_SIZE + 1);
			send_coord(x, y);
		}
	}

	//вывод графики
	@Override
	protected void paintComponent(Graphics dc){
		super.paintComponent(dc);

		int size = getWidth();
		dc.setColor(Color.WHITE);
		dc.fillRect(0, 0, size, size);

		int x, y;
		for(int i = 0; i < N_SIZE; ++i) {
			for(int j = 0; j < N_SIZE; ++j) {
				switch(field[i][j]) {
				case CELL_K:
					dc.setColor(colorK);
					x = j * CELL_SIZE;
					y = i * CELL_SIZE;
					dc.fillRect(x, y, CELL_SIZE, CELL_SIZE);
					dc.drawImage(img_K, x + ox_K, y + oy_K, null);
					break;
				case CELL_N:
					dc.setColor(colorN);
					x = j * CELL_SIZE;
					y = i * CELL_SIZE;
					dc.fillRect(x, y, CELL_SIZE, CELL_SIZE);
					dc.drawImage(img_N, j * CELL_SIZE + ox_N, i * CELL_SIZE + oy_N, null);
					break;
				}
			}
		}
		Graphics2D  dc2 = (Graphics2D)dc;
		Stroke      tmp = dc2.getStroke();
		dc2.setStroke(pen);

		dc.setColor(Color.DARK_GRAY);
		for(int i = 0; i <= size; i += CELL_SIZE){
			dc.drawLine(0, i, size, i);
			dc.drawLine(i, 0, i, size);
		}
		dc2.setStroke(tmp);
	}

	//посылка хода
	private boolean send_coord(int x, int y){
		int eof = isEofVictory(field, my_sign);

		if(eof == 1){
			dlg_main.update_user_victory();
			dlg_main.set_state_game(knForm.res.getString("VICTORY"), Color.WHITE);
		} else if(eof == 2)
			dlg_main.set_state_game(knForm.res.getString("NOT_WINNER"), Color.ORANGE);			
		else
			dlg_main.set_state_game(knForm.res.getString("NOT_HOD"), Color.GREEN);

		odata.reset();
		odata.write("{cmd:", SERVER_GAME, ", to:\"", dlg_main.getRemoteUserName().getText(), "\" x:", x, " y:", y, " eof:", eof, '}');
		boolean ret = client.write(odata);

		if(eof > 0){//показать диалог победы или ничьи
			if(eof == 1)
				knForm.dlg_error.setMsgText(knForm.res.getString("VICTORY"), Color.WHITE);
			else
				knForm.dlg_error.setMsgText(knForm.res.getString("NOT_WINNER"), Color.ORANGE);

			knForm.dlg_error.execute(dlg_main.getX(), dlg_main.getY() + dlg_main.getHeight() - knForm.dlg_error.getHeight()*2, dlg_main.getWidth(), dlg_main.getHeight());
			reset();
			try {
				Thread.sleep(500L);
			} catch(InterruptedException e){}
			
			//вдруг за это время удалённый игрок прервал игру
			if(dlg_main.getRemoteUserName().getText().length() == 0){
				dlg_main.hide_remote_user();
				my_hod.set(false);
				return false;
			}

			//1 - если один значит ход Ваш
			int hod = rnd_hod.nextInt(2);
			if(hod > 0){
				hod = 0;
				my_hod.set(true);
				dlg_main.set_state_game(knForm.res.getString("YOU_HOD"), Color.YELLOW);
			} else {
				hod = 1;
				my_hod.set(false);
				dlg_main.set_state_game(knForm.res.getString("NOT_HOD"), Color.GREEN);
			}
			odata.reset();
			odata.write("{cmd:", SERVER_NEW_GAME, " res:", ERR_GOOD_USER, " to:\"", dlg_main.getRemoteUserName().getText(), "\" from:\"", dlg_main.getUserName().getText(), "\" hod:", hod, '}');
			ret = client.write(odata);
		}
		return ret;
	}

	//отключение удалённого игрока
	public boolean disconnect_remote_user(){
		my_hod.set(false);
		reset();
		odata.reset();
		odata.write("{cmd:", SERVER_DISCONNECT, " to:\"", dlg_main.getRemoteUserName().getText(), "\"}");
		dlg_main.hide_remote_user();
		return client.write(odata);
	}

	//установить соединение
	public boolean connect(String host, int port){
		return client.create(host, port);
	}

	//запрос на регистрацию
	public boolean send_registry(String user){
		state.set(SERVER_REG_USER);
		odata.reset();
		odata.write("{cmd:", SERVER_REG_USER, " name:\"", user, "\"}");
		return client.write(odata);
	}

	//запрос на получение списка игроков
	public boolean get_list_users(){
		state.set(SERVER_LIST_USERS);
		odata.reset();
		odata.write("{cmd:", SERVER_LIST_USERS, '}');
		return client.write(odata);
	}

	//запрос пользователю с играть в игру
	public boolean to_user_game(String user_name){
		knUtil.result.set(0);
		state.set(SERVER_TO_USER);
		odata.reset();
		odata.write("{cmd:", SERVER_TO_USER, " to:\"", user_name, "\" from:\"", dlg_main.getUserName().getText(), "\"}");
		return client.write(odata);
	}

	//посылка сообщения
	public void send_message(String msg){
		if(dlg_main.isConnectRemoteUser()){
			odata.reset();
			odata.write("{cmd:", SERVER_MESSAGE, " to:\"", dlg_main.getRemoteUserName().getText(), "\" msg:\"", msg, "\"}");
			client.write(odata);
		}
	}

	//запрос на закрытие программы
	public void queryClose(){
		if(dlg_main.isConnectRemoteUser()){
			disconnect_remote_user();
			try {
				Thread.sleep(550L);
			} catch(InterruptedException e) {}
		}

		odata.reset();
		odata.write("{cmd:", SERVER_QUIT_USER, '}');
		client.write(odata);
		try {
			Thread.sleep(550L);
		} catch(InterruptedException e) {}
		client.quit();
		System.exit(0);
	}

	//получен положительный ответ для начала игры
	public void start_game(String remote){
		char sign = (rnd_hod.nextInt(2) == 0) ? CELL_K : CELL_N;
		int  hod  = rnd_hod.nextInt(2);

		//1 - если один значит ход Ваш
		if(hod > 0){
			hod = 0;
			my_hod.set(true);
			dlg_main.set_state_game(knForm.res.getString("YOU_HOD"), Color.YELLOW);
		} else {
			hod = 1;
			my_hod.set(false);
			dlg_main.set_state_game(knForm.res.getString("NOT_HOD"), Color.GREEN);
		}
		dlg_main.set_start_game(true);

		my_sign = sign;
		if(my_sign == CELL_K)
			my_sign = CELL_N;
		else if(my_sign == CELL_N)
			my_sign = CELL_K;

		dlg_main.set_sign(my_sign);

		dlg_main.link_remote_user(remote);
		odata.reset();
		odata.write("{cmd:", SERVER_ANSWER_USER, " res:", ERR_GOOD_USER, " to:\"", remote, "\" from:\"", dlg_main.getUserName().getText(), "\" sign:", sign, " hod:", hod, '}');
		state.set(SERVER_GAME);
		client.write(odata);
	}

	//получение данных
	public void read_data(kv_parser parse){
		int    res;
		String remote;

		switch(parse.getInt("cmd")){
		case SERVER_TO_USER: //запрос с играть

			remote = parse.getString("from");//"from" имя удалёного remote пользователя

			if(!show_dlg.execute(remote, this)){
				odata.reset();
				odata.write("{cmd:", SERVER_ANSWER_USER, " res:", ERR_NO_GAME, " to:\"", remote, "\" from:\"", dlg_main.getUserName().getText(), "\"}");
				client.write(odata);
				state.set(SERVER_USER_NORMAL);
			}
			return;
		case SERVER_ANSWER_USER: //присланный ответ на запрос с играть
			res = parse.getInt("res");
			switch(res){
			case ERR_NO_GAME: //пользователь отверг игру
				state.set(SERVER_USER_NORMAL);
				error_dlg.execute(parse, dlg_main, res, true);
				break;
			case ERR_GOOD_USER: //пользователь согласен на игру
				state.set(SERVER_GAME);
				my_sign = parse.getChar("sign");
				my_hod.set((parse.getInt("hod") > 0));
				error_dlg.execute(parse, dlg_main, res, false);
				break;
			case ERR_FINALIZE_USER: //пользователь покинул игру
				state.set(SERVER_USER_NORMAL);
				my_hod.set(false);
				reset();
				error_dlg.execute(parse, dlg_main, res, true);
				break;
			}
			knUtil.result.set(res);
			state_dlg.updateState(null, knUpdateState.US_ANSWER);
			return;
		case SERVER_DISCONNECT: //удалённый игрок прервал игру
			state.set(SERVER_USER_NORMAL);
			my_hod.set(false);
			error_dlg.execute(parse, dlg_main, SERVER_DISCONNECT, true);
			return;
		case SERVER_NEW_GAME:
			my_hod.set((parse.getInt("hod") > 0));
			error_dlg.execute(parse, dlg_main, SERVER_NEW_GAME, false);
			reset();
			return;
		case SERVER_MESSAGE: //приём сообщений
			error_dlg.execute(parse, dlg_main, SERVER_MESSAGE, false);
			return;
		}

		//флаги состояний пользователя
		switch(state.get()){
		case SERVER_REG_USER: //получение ответа о регистрации
			on_registry(parse);
			break;
		case SERVER_LIST_USERS: //получение списка игрoков онлайн
			on_list_users(parse);
			break;
		case SERVER_GAME: //процесс игры
			on_to_game(parse);
			break;
		}
	}

	//процесс игры
	private void on_to_game(kv_parser parse){
		int   x = parse.getInt("x");
		int   y = parse.getInt("y");
		int eof = parse.getInt("eof");

		field[y][x] = (my_sign == CELL_N) ? CELL_K : CELL_N;
		repaint();

		if(eof == 1)//вы проиграли
			state_dlg.updateState(knForm.res.getString("DEATH"), knUpdateState.US_WINNER);
		else if(eof == 2)
			state_dlg.updateState(knForm.res.getString("NOT_WINNER"), knUpdateState.US_DEFAULT);			
		else {
			my_hod.set(true);
			state_dlg.updateState(knForm.res.getString("YOU_HOD"), knUpdateState.US_DEFAULT);
		}
	}

	//регистрация
	private void on_registry(kv_parser parse){
		knUtil.result.set(parse.getInt("res"));
	}

	//список игроков онлайн
	private void on_list_users(kv_parser parse){
		int res = parse.getInt("res");
		if(res == ERR_GOOD_USER)
			parse.getString("users", knUtil.strbuf);
		knUtil.result.set(res);
	}

        //состояние игры
	public void setState(int _state){
		state.set(_state);
	}

	//сброс игрового поля
	public void reset(){
		for(int i = 0; i < field.length; ++i) {
			for(int j = 0; j < field[i].length; ++j)
				field[i][j] = CELL_NONE;
		}
		repaint();
	}

	public void setDialogTo(knDlgToUser dlg){
		dlg_to = dlg;
	}

	public ByteChars getOutput(){
		return odata;
	}

	public knTCPClient getTCPClient(){
		return client;
	}

	//проверка выигрыш
	private int isEofVictory(char[][] field, char sign){
		//проверка по строкам
		int n, m = field.length;
		for(int i = 0; i < m; ++i){
			n = 0;
			while((n < m) && (field[i][n] == sign))
				++n;
			if(n == m)
				return 1;
		}

		//проверка по столбцам
		for(int i = 0; i < m; ++i){
			n = 0;
			while((n < m) && (field[n][i] == sign))
				++n;
			if(n == m)
				return 1;
		}

		//проверка главной диагонали
		n = 0;
		while((n < m) && (field[n][n] == sign))
			++n;
		if(n == m)
			return 1;

		//проверка побочной диагонали
		n = 0;
		while((n < m) && (field[n][m - 1 - n] == sign))
			++n;
		if(n == m)
			return 1;
		
		//проверка на ничью
		n = 0;
		for(int i = 0; i < m; ++i){
			for(int j = 0; j < m; ++j){
				if(field[i][j] != CELL_NONE)
					++n;
			}
		}
		return (n == (m*m)) ? 2 : 0;
	}
}
