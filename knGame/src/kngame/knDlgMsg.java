//Автор(с): Кудуштеев Алексей
package kngame;
import javax.swing.JDialog;

import java.awt.Frame;
import java.awt.FlowLayout;

import javax.swing.JButton;

import java.awt.Dimension;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;
import java.awt.event.WindowAdapter;

import javax.swing.JTextField;
import javax.swing.JPanel;


//диалог для посылки сообщений
@SuppressWarnings("serial")
public class knDlgMsg extends JDialog {
	private boolean     send_ok  = false;
	private JTextField  edit_msg = new JTextField();

	public knDlgMsg(Frame frame){
		super(frame, knForm.res.getString("MSG"));
		try {
                	create();
                } catch(Exception e){}
	}

	private void create() throws Exception {
		int width  = 380;
		int height = 96;
		setDefaultCloseOperation(JDialog.DO_NOTHING_ON_CLOSE);
		setPreferredSize(new Dimension(width, height));
		setSize(width, height);
		setResizable(false);
		setModal(true);

		FlowLayout lay = new FlowLayout(FlowLayout.RIGHT);
		JPanel p = (JPanel)getContentPane();
		p.setLayout(lay);

		int h = edit_msg.getFont().getSize() * 2 - 1;
		edit_msg.setPreferredSize(new Dimension(width - 16, h));
		p.add(edit_msg);

		ActionListener ebut = new ActionListener(){
			public void actionPerformed(ActionEvent e){
                                knDlgMsg.this.button_command(e.getActionCommand());
			}
		};

		JButton bok = new JButton(knForm.res.getString("SEND_MSG"));
		bok.setPreferredSize(new Dimension(180, bok.getFont().getSize() * 2));
		bok.addActionListener(ebut);
		bok.setActionCommand("SEND");
		p.add(bok);

		JButton bno = new JButton(knForm.res.getString("CLOSE"));
		bno.setPreferredSize(new Dimension(90, bno.getFont().getSize() * 2));
		bno.addActionListener(ebut);
		bno.setActionCommand("CLOSE");
		p.add(bno);

		WindowListener wl = new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				knDlgMsg.this.on_close();
			}
		};
		addWindowListener(wl);
	}

	public boolean execute(Frame frame){
		send_ok = false;
		edit_msg.setText("");
		setLocation(frame.getX() + (frame.getWidth() - getWidth())/2, frame.getY() + (frame.getHeight() - getHeight())/2);
		setVisible(true);
		return send_ok;
	}

	//команды кнопок
	private void button_command(String cmd){
		if(cmd.compareTo("CLOSE") == 0)
			on_close();
		else if(cmd.compareTo("SEND") == 0){
			if(edit_msg.getText().length() > 0){
				send_ok = true;
				setVisible(false);
			}
		}
	}

	//закрытие
	private void on_close(){
		send_ok = false;
		setVisible(false);
	}

	public JTextField getTextField(){
		return edit_msg;
	}
}
