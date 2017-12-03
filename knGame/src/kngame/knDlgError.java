//Автор(с): Кудуштеев Алексей
package kngame;
import javax.swing.JDialog;
import javax.swing.JLabel;

import java.awt.Dimension;
import java.awt.FlowLayout;

import javax.swing.JPanel;

import java.awt.Frame;

import javax.swing.JButton;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;
import java.awt.event.WindowAdapter;
import java.awt.Color;
import java.awt.Toolkit;
import java.awt.Image;

import javax.swing.ImageIcon;


//диалог для вывода сообщений от пользователя
@SuppressWarnings("serial")
public class knDlgError extends JDialog {
	private JLabel ltext = new JLabel();

	public knDlgError(Frame frame) {
		super(frame, knForm.res.getString("MSG"));
		try {
			create();
		} catch(Exception e){}
	}

	private void create() throws Exception {
		int width  = 520;
		int height = 153;
		setDefaultCloseOperation(JDialog.DO_NOTHING_ON_CLOSE);
		setPreferredSize(new Dimension(width, height));
		setSize(width, height);
		setResizable(false);
		setModal(true);

		FlowLayout lay = new FlowLayout(FlowLayout.CENTER);
		JPanel p = (JPanel)getContentPane();
		p.setLayout(lay);
		p.setBackground(new Color(0, 0, 0x33));

		Image     img = Toolkit.getDefaultToolkit().createImage(getClass().getResource("data/message.png"));
		ImageIcon ico = new ImageIcon(img);
		JLabel   icon = new JLabel(ico);
		icon.setPreferredSize(new Dimension(img.getWidth(null), img.getHeight(null)));
		ico = null;
		img = null;
		p.add(icon);

		int w = width - 8;
		int h = 40;
		ltext.setPreferredSize(new Dimension(w, h));
		ltext.setHorizontalAlignment(JLabel.CENTER);
		ltext.setForeground(Color.GREEN);
		p.add(ltext);

		JButton but = new JButton(knForm.res.getString("CLOSE"));
		w = 110;
		h = but.getFont().getSize() * 2 + 1;
		but.setPreferredSize(new Dimension(w, h));
		but.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e){
				knDlgError.this.on_close();
			}
		});
		p.add(but);

		WindowListener wl = new WindowAdapter(){
			public void windowClosing(WindowEvent e) {
				knDlgError.this.on_close();
			}
		};
		addWindowListener(wl);
	}

	public void setMsgText(String str, Color color){
		ltext.setText(str);
		ltext.setForeground(color);
	}

	public void execute(int x, int y, int w, int h){
		setLocation(x + (w - getWidth()) / 2, y + (h - getHeight()) / 2);
		setVisible(true);
	}

	private void on_close(){
		setVisible(false);
	}
}
