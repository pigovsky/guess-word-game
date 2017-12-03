//Автор(с): Кудуштеев Алексей
package kngame;
import javax.swing.JDialog;
import javax.swing.JLabel;

import java.awt.FlowLayout;

import javax.swing.JButton;

import java.awt.Dimension;
import java.awt.Frame;

import javax.swing.JPanel;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.Color;
import java.awt.Toolkit;
import java.awt.Image;

import javax.swing.JTextArea;
import javax.swing.ImageIcon;

import java.awt.Font;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;
import java.awt.event.WindowAdapter;


//диалог приглашения
@SuppressWarnings("serial")
public class knDlgToUser extends JDialog {
	private boolean   game_link  = false;
	private JLabel    label_user = new JLabel();
	private JTextArea label_text = new JTextArea();
	private Frame         pframe = null;

	public knDlgToUser(Frame frame){
		super(frame, knForm.res.getString("TO_USER"));
		try {
			pframe = frame;
			create();
		} catch(Exception e){}
	}

	private void create() throws Exception {
		int width  = 340;
		int height = 220;
		setDefaultCloseOperation(JDialog.DO_NOTHING_ON_CLOSE);
		setPreferredSize(new Dimension(width, height));
		setSize(width, height);
		setResizable(false);
		setModal(true);

		FlowLayout lay = new FlowLayout(FlowLayout.CENTER);
		JPanel p = (JPanel)getContentPane();
		p.setLayout(lay);

		Image     img = Toolkit.getDefaultToolkit().createImage(getClass().getResource("data/to.png"));
		ImageIcon ico = new ImageIcon(img);
		JLabel   icon = new JLabel(ico);
		icon.setPreferredSize(new Dimension(img.getWidth(null), 32));
		img = null;
		p.add(icon);

		Font font = new Font(label_user.getFont().getName(), Font.BOLD, 14);
		label_user.setFont(font);

		int w = width - 70;
		int h = font.getSize() * 2 - 8;
		label_user.setPreferredSize(new Dimension(w, h));
		label_user.setHorizontalAlignment(JLabel.CENTER);
		label_user.setForeground(new Color(0, 0x65, 0));
		label_user.setBorder(javax.swing.BorderFactory.createLineBorder(Color.GRAY));
		p.add(label_user);

		label_text.setPreferredSize(new Dimension(w + 40, 106));
		label_text.setWrapStyleWord(true);
		label_text.setLineWrap(true);
		label_text.setEditable(false);
		label_text.setMargin(new java.awt.Insets(10, 2, 2, 2));
		label_text.setFont(new Font(label_user.getFont().getName(), Font.PLAIN, 13));
		label_text.setBackground(getBackground());
		p.add(label_text);

		JButton bok = new JButton(knForm.res.getString("YES_GAME"));
		bok.setForeground(Color.BLUE);
		bok.setPreferredSize(new Dimension(110, bok.getFont().getSize() * 2 + 1));
		ActionListener ebut = new ActionListener(){
			public void actionPerformed(ActionEvent e){
				knDlgToUser.this.button_command(e.getActionCommand());
			}
		};
		bok.addActionListener(ebut);
		bok.setActionCommand("YES");
		p.add(bok);

		JButton bno = new JButton(knForm.res.getString("NOT_GAME"));
		bno.setForeground(Color.RED);
		bno.setPreferredSize(bok.getPreferredSize());
		bno.addActionListener(ebut);
		bno.setActionCommand("NO");
		p.add(bno);

		WindowListener wl = new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				knDlgToUser.this.on_close();
			}
		};
		addWindowListener(wl);
	}

	//запуск
	public boolean execute(boolean center, String remote_user){
		game_link = false;
		if(center){
			Dimension ssize = Toolkit.getDefaultToolkit().getScreenSize();
			setLocation((int)(ssize.getWidth() - getWidth())/2, (int)(ssize.getHeight() - getHeight())/2);
		} else
			setLocation(pframe.getX() + (pframe.getWidth() - getWidth())/2, pframe.getY() + (pframe.getHeight() - getHeight())/2);

		label_user.setText(remote_user);
		label_text.setText(remote_user + knForm.res.getString("TEXT_USER"));
		setVisible(true);
		return game_link;
	}

	private void button_command(String cmd){
		if(cmd.compareTo("NO") == 0)
			on_close();
		else if(cmd.compareTo("YES") == 0)
			on_link();
	}

	private void on_close(){
		game_link = false;
		setVisible(false);
	}

	//соединение с удалённым ползователем, то бишь игроком
	private void on_link(){
		game_link = true;
		setVisible(false);
	}
}
