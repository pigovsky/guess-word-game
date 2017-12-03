//Автор(с): Кудуштеев Алексей
package kngame;
import javax.swing.JDialog;
import javax.swing.JTextField;
import javax.swing.JLabel;

import java.awt.FlowLayout;

import javax.swing.JButton;

import java.awt.Dimension;

import javax.swing.JPanel;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.Color;
import java.awt.Toolkit;
import java.awt.Image;

import javax.swing.ImageIcon;
import javax.swing.JSeparator;


//диалог для установки соединения с сервером
@SuppressWarnings("serial")
final class knDlgConnect extends JDialog {
	private boolean     connect   = false;
	private boolean     good_reg  = false;
	private JTextField  edit_host = new JTextField("localhost");
	private JTextField  edit_port = new JTextField("7777");
	private JTextField  edit_user = new JTextField();
	private JLabel     label_user = new JLabel();
	private JLabel           lbl1 = new JLabel(knForm.res.getString("HOST"));
	private JLabel           lbl2 = new JLabel(knForm.res.getString("PORT"));
	private JLabel           lbl3 = new JLabel(knForm.res.getString("USER"));
	private JButton        bconn  = new JButton(knForm.res.getString("LINK"));
	private knPanelField   fpanel = null;
	public  knForm         dlg_p  = null;

	public knDlgConnect(knForm dlg_m, knPanelField panel) {
		super(dlg_m, knForm.res.getString("CONNECT"));
		try {
			dlg_p  = dlg_m;
			fpanel = panel;
			create();
		} catch(Exception e){ e.printStackTrace(); }
	}

	private void create() throws Exception {
		int width  = 340;
		int height = 250;
		setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);
		setPreferredSize(new Dimension(width, height));
		setSize(width, height);
		setResizable(false);
		setModal(true);

		FlowLayout lay = new FlowLayout(FlowLayout.CENTER);
		JPanel p = (JPanel)getContentPane();
		p.setLayout(lay);

		Image     img = Toolkit.getDefaultToolkit().createImage(getClass().getResource("data/logo.png"));
		ImageIcon ico = new ImageIcon(img);
		JLabel   icon = new JLabel(ico);
		icon.setPreferredSize(new Dimension(img.getWidth(null), 64));
		img  = null;
		p.add(icon);

		lbl1.setPreferredSize(new Dimension(width / 3, lbl1.getFont().getSize() * 2));
		lbl1.setHorizontalAlignment(JLabel.RIGHT);
		lbl1.setForeground(Color.BLUE);
		p.add(lbl1);

		int w = getWidth() / 2;
		int h = edit_host.getFont().getSize() * 2;
		edit_host.setPreferredSize(new Dimension(w, h));
		p.add(edit_host);

		lbl2.setPreferredSize(lbl1.getPreferredSize());
		lbl2.setHorizontalAlignment(JLabel.RIGHT);
		lbl2.setForeground(Color.BLUE);
		p.add(lbl2);

		edit_port.setPreferredSize(edit_host.getPreferredSize());
		p.add(edit_port);

                lbl3.setPreferredSize(lbl1.getPreferredSize());
                lbl3.setHorizontalAlignment(JLabel.RIGHT);
                lbl3.setForeground(new Color(0x33, 0x88, 0x23));
		lbl3.setEnabled(false);
                p.add(lbl3);

		edit_user.setPreferredSize(edit_host.getPreferredSize());
		edit_user.setEnabled(false);
		p.add(edit_user);

		JSeparator sep = new JSeparator(JSeparator.HORIZONTAL);
		sep.setPreferredSize(new Dimension(width - 35, 16));
		p.add(sep);

		bconn.setPreferredSize(new Dimension(200, bconn.getFont().getSize() * 2 + 1));
		ActionListener ebut = new ActionListener(){
			public void actionPerformed(ActionEvent e){
				knDlgConnect.this.button_connect(e.getActionCommand());
			}
		};
		bconn.addActionListener(ebut);
		bconn.setActionCommand("OK");
		p.add(bconn);

		JButton bnot = new JButton(knForm.res.getString("QUIT"));
		bnot.setPreferredSize(new Dimension(80, bconn.getFont().getSize() * 2 + 1));
		bnot.addActionListener(ebut);
		bnot.setActionCommand("NO");
		p.add(bnot);

		knConfig.load();
		edit_host.setText(knConfig.host_ip);
		edit_port.setText(String.valueOf(knConfig.port));
	}

	public boolean execute(){
		connect = good_reg = false;
		Dimension ssize = Toolkit.getDefaultToolkit().getScreenSize();
		setLocation((int)(ssize.getWidth() - getWidth())/2, (int)(ssize.getHeight() - getHeight())/2);
		setVisible(true);
        	return good_reg;
	}

	private void button_connect(String cmd){
		if(cmd.compareTo("NO") == 0){
			connect = false;
			setVisible(false);
		} else if(cmd.compareTo("OK") == 0){

			if(! connect){//установка соединения
				String host = edit_host.getText();
				String port = edit_port.getText();
				if((host.length() == 0) || (port.length() == 0))
					return;

				bconn.setEnabled(false);
				int iport = Integer.valueOf(port);
				if(fpanel.connect(host, iport)) {
					connect = true;
					label_user.setEnabled(true);
					edit_user.setEnabled(true);
					lbl3.setEnabled(true);
					edit_host.setEnabled(false);
					edit_port.setEnabled(false);
					lbl1.setEnabled(false);
					lbl2.setEnabled(false);
					bconn.setEnabled(true);
					bconn.setText(knForm.res.getString("REG"));
					setTitle(knForm.res.getString("REG_USER"));
					knConfig.save(host, iport);
				} else {
					knForm.dlg_error.setMsgText(knForm.res.getString("ERR_NETWORK"), Color.WHITE);
					knForm.dlg_error.execute(getX(), getY(), getWidth(), getHeight());
					bconn.setEnabled(true);
				}
			} else { // зарегистрироваться
				String user = edit_user.getText();
				if(user.length() == 0)
					return;
				user = user.toLowerCase();

				String  s = "";
				boolean m = true;
				for(int i = 0; i < user.length(); ++i){
					if(Character.isLowerCase(user.charAt(i)) && m){
						s += Character.toUpperCase(user.charAt(i));
						m  = false;
					} else if((user.charAt(i) != '"') && (user.charAt(i) != ','))
						s += user.charAt(i);
				}
				user = s;

				if(fpanel.send_registry(user)){//регистрация
					for(int i = 0; i < 70; ++i){
						try {
							Thread.sleep(knUtil.SLEEP_MSEC);
						} catch(InterruptedException e){ e.printStackTrace(); }

						int res = knUtil.result.get();
						if(res == knPanelField.ERR_GOOD_USER) {
							dlg_p.my_info_user(user);
							good_reg = true;
							setVisible(false);
							break;
						} else if(res == knPanelField.ERR_ALREADY_USER) {
							edit_user.setText("");
							knForm.dlg_error.setMsgText(knForm.res.getString("ALREADY_USER"), Color.ORANGE);
							knForm.dlg_error.execute(getX(), getY(), getWidth(), getHeight());
							break;
						}
					}
				} else {
					knForm.dlg_error.setMsgText(knForm.res.getString("ERR_USER"), Color.RED);
					knForm.dlg_error.execute(getX(), getY(), getWidth(), getHeight());
				}
			}
		}
	}
}
