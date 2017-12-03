//Автор(с): Кудуштеев Алексей
package kngame;
import javax.swing.JFrame;
import java.awt.Dimension;
import java.awt.Toolkit;
import java.awt.FlowLayout;
import java.util.ResourceBundle;
import javax.swing.JPanel;
import javax.swing.JMenuBar;
import javax.swing.JMenu;
import javax.swing.JMenuItem;
import java.awt.Color;
import javax.swing.JLabel;
import java.awt.Image;
import javax.swing.ImageIcon;
import javax.swing.BorderFactory;
import java.awt.Font;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;
import java.awt.event.WindowAdapter;
import javax.swing.JTextArea;


//класс-формы
@SuppressWarnings("serial")
public class knForm extends JFrame {
	public  static ResourceBundle res = ResourceBundle.getBundle("kngame.Res");
	private knPanelField         fpanel = null;
	private JMenuBar               mbar = new JMenuBar();
	public static knDlgUsers     dlg_us = null;
	private knDlgToUser          dlg_to = null;
	private JPanel           panel_user = new JPanel(false);
	private JPanel    panel_remote_user = new JPanel(false);
	private JLabel    label_user        = new JLabel();
	private JLabel    label_remote_user = new JLabel();
	private JLabel             win_user = new JLabel("0");
	private JLabel      win_remote_user = new JLabel("0");
	private JLabel           label_sign = new JLabel();
	private JLabel     icon_remote_user = null;
	private JTextField       state_game = new JTextField(res.getString("NO_GAME"));
	private JLabel           start_game = new JLabel(res.getString("START_GAME"));
	private JButton     off_remote_user = new JButton(res.getString("SELECT_USER"));
	private JTextArea          msg_area = new JTextArea();
	private int                cnt_user = 0;
	private int         cnt_remote_user = 0;
	private JMenuItem         menu_user = null;
	private JMenuItem          menu_msg = null;
	public static knDlgError  dlg_error = null;
	public static knDlgMsg    dlg_msg   = null;

	public knForm(){
		super(res.getString("APPNAME"));
		try {
			create();
		} catch(Exception e){ }
	}

	private void create() throws Exception {
		setDefaultCloseOperation(EXIT_ON_CLOSE);

		int width  = 640;
		int height = 480;
		setPreferredSize(new Dimension(width, height));
		setSize(width, height);
		setResizable(false);

		FlowLayout lay = new FlowLayout();
		lay.setAlignment(FlowLayout.CENTER);

		fpanel = new knPanelField(this, width, height);

		JPanel panel = (JPanel)getContentPane();
		panel.setLayout(lay);

		Font fnt = new Font(state_game.getFont().getName(), Font.BOLD, 14);
		int   cw = width - 20;
		int   ch = fnt.getSize() + 8;
		state_game.setFont(fnt);
		state_game.setBorder(BorderFactory.createLineBorder(Color.ORANGE));
		state_game.setForeground(Color.YELLOW);
		state_game.setBackground(new Color(0, 0, 0x44));
		state_game.setHorizontalAlignment(JTextField.CENTER);
		state_game.setEditable(false);
		state_game.setPreferredSize(new Dimension(cw, ch));
		panel.add(state_game);

		panel_user.setPreferredSize(new Dimension(146, fpanel.getHeight()));
		panel.add(panel_user);

		panel.add(fpanel);

		panel_remote_user.setPreferredSize(panel_user.getPreferredSize());
		panel.add(panel_remote_user);

		ActionListener ebut = new ActionListener(){
			public void actionPerformed(ActionEvent e){
				knForm.this.button_command(e.getActionCommand());
			}
		};

		JMenu menu1 = new JMenu(res.getString("SEL_USERS"));
		menu_user   = menu1.add(res.getString("SELECT_USER"));
		menu_user.addActionListener(ebut);
		menu_user.setActionCommand("SELECT");
		menu1.addSeparator();
		JMenuItem item = menu1.add(res.getString("EXIT"));
		item.addActionListener(ebut);
		item.setActionCommand("EXIT");
		mbar.add(menu1);

		JMenu menu2 = new JMenu(res.getString("MSG"));
		menu_msg    = menu2.add(res.getString("SEND_MSG"));
		menu_msg.addActionListener(ebut);
		menu_msg.setActionCommand("MSG");
		menu_msg.setEnabled(false);
		mbar.add(menu2);

		JMenu menu3 = new JMenu(res.getString("HELP"));
		item = menu3.add(res.getString("SHOW_HELP"));
		item.addActionListener(ebut);
		item.setActionCommand("HELP");
		mbar.add(menu3);

		setJMenuBar(mbar);

		int w = 134;
		int h = label_user.getFont().getSize() * 2 - 2;
		label_user.setPreferredSize(new Dimension(w, h));
		label_user.setHorizontalAlignment(JLabel.CENTER);

		if(!(panel_user.getLayout() instanceof FlowLayout))
			panel_user.setLayout(new FlowLayout(FlowLayout.CENTER));

		put_label_icon(panel_user, "data/from.png");
		panel_user.add(label_user);

		label_remote_user.setPreferredSize(label_user.getPreferredSize());
		label_remote_user.setHorizontalAlignment(JLabel.CENTER);

		if(!(panel_remote_user.getLayout() instanceof FlowLayout))
			panel_remote_user.setLayout(new FlowLayout(FlowLayout.CENTER));

		icon_remote_user = put_label_icon(panel_remote_user, "data/to.png");
		panel_remote_user.add(label_remote_user);

		w = h = 48;
		win_user.setFont(new Font(win_user.getFont().getName(), Font.BOLD, 24));
		win_user.setHorizontalAlignment(JLabel.CENTER);
		win_user.setPreferredSize(new Dimension(w, h));
		win_user.setToolTipText(res.getString("WINNER"));
		win_user.setForeground(Color.BLUE);
		panel_user.add(win_user);

		label_sign.setPreferredSize(new Dimension(146, label_sign.getFont().getSize() * 2 - 5));
		label_sign.setHorizontalAlignment(JLabel.CENTER);
		panel_user.add(label_sign);

		win_remote_user.setFont(win_user.getFont());
		win_remote_user.setHorizontalAlignment(JLabel.CENTER);
		win_remote_user.setPreferredSize(win_user.getPreferredSize());
		win_remote_user.setToolTipText(win_user.getToolTipText());
		win_remote_user.setForeground(Color.BLUE);
		panel_remote_user.add(win_remote_user);
		hide_remote_user();

		msg_area.setPreferredSize(new Dimension(130, 150));
		msg_area.setBorder(javax.swing.BorderFactory.createEtchedBorder());
		msg_area.setLineWrap(true);
		msg_area.setEditable(false);
		msg_area.setWrapStyleWord(true);
		msg_area.setVisible(false);
		msg_area.setToolTipText(res.getString("GET_MSG"));
		panel_remote_user.add(msg_area);

		start_game.setPreferredSize(new Dimension(fpanel.getWidth(), state_game.getFont().getSize() + 8));
		start_game.setHorizontalAlignment(JLabel.CENTER);
		start_game.setFont(state_game.getFont());
		start_game.setForeground(Color.GRAY);
		start_game.setBorder(javax.swing.BorderFactory.createLineBorder(Color.GRAY));
		start_game.setVisible(false);
		panel.add(start_game);

		off_remote_user.setPreferredSize(start_game.getPreferredSize());
		off_remote_user.addActionListener(ebut);
		off_remote_user.setActionCommand("OFF");
		panel.add(off_remote_user);

		dlg_error = new knDlgError(this);
		dlg_msg   = new knDlgMsg(this);

		knDlgConnect dlg = new knDlgConnect(this, fpanel);
		if(! dlg.execute()){
			System.exit(0);
			return;
		} else {
			dlg.dispose();
			dlg = null;
		}

		dlg_to = new knDlgToUser(this);
		fpanel.setDialogTo(dlg_to);

		dlg_us = new knDlgUsers(this, fpanel);
		dlg_us.execute(this, true);

		WindowListener wl = new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				knForm.this.on_close();
			}
		};
		addWindowListener(wl);
	}

	//команды
	private void button_command(String cmd){
		if(cmd.compareTo("OFF") == 0){
			
			if(isConnectRemoteUser())
				fpanel.disconnect_remote_user();
			else
				dlg_us.execute(this, true);
			
		} else if(cmd.compareTo("EXIT") == 0)
			on_close();
		else if(cmd.compareTo("SELECT") == 0){
			
			if(isConnectRemoteUser())//удалённый игрок соединён
				fpanel.disconnect_remote_user();
			else
				dlg_us.execute(this, true);

		} else if(cmd.compareTo("MSG") == 0){ //посылка сообщения
			
			if(dlg_msg.execute(this)){
				String s = dlg_msg.getTextField().getText();
				if(s.indexOf('"') != -1)
					s = s.replace('"', '\'');
				fpanel.send_message(s);
			}
		} else if(cmd.compareTo("HELP") == 0)//справка
			javax.swing.JOptionPane.showMessageDialog(this, res.getObject("CONTNET"), res.getString("HELP"), javax.swing.JOptionPane.QUESTION_MESSAGE);
	}

	private void on_close(){
		fpanel.queryClose();
	}

	private JLabel put_label_icon(JPanel panel, String res){
		Image     img = Toolkit.getDefaultToolkit().createImage(getClass().getResource(res));
		ImageIcon ico = new ImageIcon(img);
		JLabel   icon = new JLabel(ico);
		icon.setPreferredSize(new Dimension(32, 32));
		ico = null;
		img = null;
		panel.add(icon);
		return icon;
	}

	public void link_remote_user(String user_name){
		label_remote_user.setText(user_name);
		icon_remote_user.setVisible(true);
		win_remote_user.setVisible(true);
		win_remote_user.setText("0");
		fpanel.reset();
		menu_user.setText(res.getString("OFF_USER"));
		menu_msg.setEnabled(true);
		msg_area.setText("");
		msg_area.setVisible(true);
		off_remote_user.setText(res.getString("OFFLINE"));
	}

	public void hide_remote_user(){
		label_remote_user.setText("");
		icon_remote_user.setVisible(false);
		win_remote_user.setVisible(false);
		win_remote_user.setText("0");
		set_state_game(knForm.res.getString("NO_GAME"), Color.RED);
		start_game.setVisible(false);
		fpanel.reset();
		win_user.setText("0");
		cnt_user = cnt_remote_user = 0;
		
		String s = res.getString("SELECT_USER");
		menu_user.setText(s);
		off_remote_user.setText(s);
		menu_msg.setEnabled(false);
		msg_area.setVisible(false);
		msg_area.setText("");
		label_sign.setText("");
	}

	public void set_sign(char sign){
		if(sign == knPanelField.CELL_N)
			label_sign.setText(res.getString("SIGN_N"));
		else if(sign == knPanelField.CELL_K)
			label_sign.setText(res.getString("SIGN_K"));
	}

	public void set_start_game(boolean visible){
		start_game.setVisible(visible);
	}

	public void set_state_game(String str, Color color){
		state_game.setForeground(color);
		state_game.setText(str);
	}

	public void my_info_user(String user_name){
		label_user.setText(user_name);
		setTitle(res.getString("APPNAME") + " - " + user_name);
		win_user.setText("0");
	}

	public void update_remote_user_victory(){
		cnt_remote_user += 1;
		win_remote_user.setText(String.valueOf(cnt_remote_user));
	}

	public void update_user_victory(){
		cnt_user += 1;
		win_user.setText(String.valueOf(cnt_user));
	}

	public void put_message(String msg){
		msg_area.setText(msg);
	}

	public boolean isConnectRemoteUser(){
		return icon_remote_user.isVisible();
	}

	public JLabel getUserName(){
		return label_user;
	}

	public JLabel getRemoteUserName(){
		return label_remote_user;
	}
}
