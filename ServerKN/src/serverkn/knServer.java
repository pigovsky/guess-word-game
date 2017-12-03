/* Автор игры(с): Кудуштеев Алексей
   Для начинающих программистов
*/
package serverkn;
import java.net.*;
import java.io.*;
import javax.swing.JDialog;
import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Dimension;
import java.awt.Toolkit;
import javax.swing.JPanel;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowListener;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JTextField;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import javax.swing.JOptionPane;


@SuppressWarnings("serial")
final class knDialog extends JDialog {
	private knServer       server = new knServer();
	private JTextField  edit_port = new JTextField("7777");
	private JLabel    label_users = new JLabel("0");
	private JButton     but_utext = new JButton("Количество пользователей");
	private JButton     but_start = new JButton("Запустить сервер");

	public knDialog(){
		try {
			create();
		}catch(Exception e){e.printStackTrace();}
	}

	private void create()throws Exception {
		int width  = 340;
		int height = 204;
		setTitle("Сервер игры \"Крестики нолики\"");
		setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);
		setPreferredSize(new Dimension(width, height));
		setSize(width, height);
		setResizable(false);
		setModal(true);

		Dimension ssize = Toolkit.getDefaultToolkit().getScreenSize();
		Dimension fsize = getSize();
		setLocation((ssize.width - fsize.width) / 2, (ssize.height - fsize.height) / 2);

		FlowLayout lay = new FlowLayout(FlowLayout.CENTER);
		JPanel p = (JPanel)getContentPane();
		lay.setVgap(30);
		p.setLayout(lay);

		ActionListener ebut = new ActionListener(){
			public void actionPerformed(ActionEvent e){
				knDialog.this.button_command(e.getActionCommand());
			}
		};

		JLabel lbl = new JLabel("Порт:");
		p.add(lbl);

		int h = edit_port.getFont().getSize() * 2 - 2;
		edit_port.setPreferredSize(new Dimension(80, h));
		p.add(edit_port);

		but_start.setPreferredSize(new Dimension(250, but_start.getFont().getSize()*2));
		but_start.addActionListener(ebut);
		but_start.setActionCommand("START");
		p.add(but_start);

		but_utext.setVisible(false);
		but_utext.addActionListener(ebut);
		but_utext.setActionCommand("USERS");		
		p.add(but_utext);

		label_users.setPreferredSize(new Dimension(80, label_users.getFont().getSize() * 2 - 2));
		label_users.setBorder(javax.swing.BorderFactory.createLineBorder(Color.GRAY));
		label_users.setHorizontalAlignment(JLabel.CENTER);
		label_users.setVisible(false);
		p.add(label_users);
		
		WindowListener wl = new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				knDialog.this.on_close();
			}
		};
		addWindowListener(wl);

		setVisible(true);
	}

	private void button_command(String cmd){
		if(cmd.compareTo("START") == 0){
			String str = edit_port.getText();
			if(str.length() > 0){
				if(server.create(Integer.valueOf(str))){
					label_users.setVisible(true);
					but_utext.setVisible(true);
					but_start.setEnabled(false);
					edit_port.setEnabled(false);
					server.startup();
				} else {
					edit_port.setText("7777");
					JOptionPane.showMessageDialog(this, "Сервер не был запущен!", "Ошибка", JOptionPane.ERROR_MESSAGE);
				}
			}
		} else if(cmd.compareTo("USERS") == 0)
			label_users.setText(String.valueOf(knUsers.count_users()));
	}

	private void on_close(){
		server.quit();
		knUsers.removeAll();
	}
}


//сервер класс-приложение
public class knServer implements Runnable {
	private Thread        thd  = null;
	private ServerSocket  sock = null;

	//создание
	public boolean create(int port){
		boolean ret = true;
		try {
			sock = new ServerSocket();
			sock.bind(new InetSocketAddress(port));
		} catch(Exception e){
			ret = false;
		} finally {
			if(!ret && (sock != null)){
				try { sock.close(); } catch(IOException e){}
				sock = null;
			}
		}
		return ret;
	}
	
	public void startup(){
		knUsers.initialize();

		//запускаем поток
		thd = new Thread(this);
		thd.start();
	}

	public void run(){
		while(true){
			try {
				Socket user = sock.accept();
				if(! knUsers.add(user))
					user.close();
			} catch(IOException e){
				break;
			}
		}
	}

	public void wait_server(){
		try {
			thd.join();
		} catch(InterruptedException e){ }
	}

	public void quit(){
		if(sock == null)
			return;
		
		try {
			sock.close();
		} catch(IOException e){
		} finally {
			sock = null;
		}
	}

	//точка входа
	public static void main(String[] args) {
		new knDialog();
	}
}
