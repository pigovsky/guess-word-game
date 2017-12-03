//Автор(с): Кудуштеев Алексей
package kngame;
import java.lang.Thread;
import java.net.Socket;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.IOException;


//клиентский поток
final public class knTCPClient implements Runnable {
	private static final int MAX_BUF = 512;
	private Socket         sock = null;
	private Thread         thd  = null;
	private InputStream    s_in = null;
	private OutputStream  s_out = null;
	private kv_parser     parse = new kv_parser();
	private knPanelField pfield = null;

	public knTCPClient(knPanelField field){
		pfield = field;
	}

	//создание
	public boolean create(String host, int port){
		try {
			sock  = new Socket(host, port);
			s_in  = sock.getInputStream();
			s_out = sock.getOutputStream();
		} catch(Exception e){
			if(sock != null){
				try { sock.close(); } catch(IOException err){}
			}
			sock  = null;
			s_in  = null;
			s_out = null;
			return false;
		}
		thd = new Thread(this);
		thd.start();
		return true;
	}

	//посылка данных
	public boolean write(ByteChars bch){
		try {
			s_out.write(bch.getData(), 0, bch.getCount());
		} catch(IOException e){
			return false;
		}
                return true;
	}

	//закрыть
	public void quit(){
		if(sock != null){
			try {
				sock.close();
			} catch(IOException e){
			} finally {
				sock  = null;
				s_in  = null;
				s_out = null;
			}
		}

		if(thd != null){
			try {
				thd.join();
			} catch(InterruptedException e){}
			thd = null;
		}
	}

	public void run(){
		final byte[] buf = new byte[MAX_BUF];
		int n;
		while(true){
			try {
				n = s_in.read(buf);
			} catch(IOException e){
                        	break;
			}

			if(n > 0){
				parse.add(buf, n);
				if(parse.isBlockData())
					pfield.read_data(parse);
			} else
				break;
		}
	}

	public kv_parser getParser(){
		return parse;
	}
}

