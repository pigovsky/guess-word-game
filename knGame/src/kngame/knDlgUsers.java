//Автор(с): Кудуштеев Алексей
package kngame;
import javax.swing.JDialog;
import java.awt.Frame;
import javax.swing.JLabel;
import java.awt.FlowLayout;
import javax.swing.JButton;
import java.awt.Dimension;
import javax.swing.JPanel;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.Color;
import java.awt.Toolkit;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;
import java.awt.event.WindowAdapter;
import javax.swing.JList;
import javax.swing.JScrollPane;
import javax.swing.DefaultListModel;


//список доступных игроков в онлайн
@SuppressWarnings("serial")
public class knDlgUsers extends JDialog {
	private boolean    select_user = false;
	private knPanelField    fpanel = null;
	private DefaultListModel model = new DefaultListModel();
	private JList           lusers = new JList(model);
	private JScrollPane      spane = new JScrollPane();
	private JButton        bselect = new JButton(knForm.res.getString("SEL_BUT"));
	private JButton           bnot = new JButton(knForm.res.getString("SEL_NOT"));

	public knDlgUsers(Frame frame, knPanelField panel){
		super(frame, knForm.res.getString("USERS"));
		try {
			fpanel = panel;
			create();
		} catch(Exception e){}
	}

	private void create() throws Exception {
		int width  = 300;
		int height = 400;
		setDefaultCloseOperation(JDialog.DO_NOTHING_ON_CLOSE);
		setPreferredSize(new Dimension(width, height));
		setSize(width, height);
		setResizable(false);
		setModal(true);

		FlowLayout lay = new FlowLayout(FlowLayout.CENTER);
		JPanel p = (JPanel)getContentPane();
		p.setLayout(lay);

		JLabel lbl = new JLabel(knForm.res.getString("SEL_USER"));
		lbl.setForeground(new Color(0, 0x77, 0));
		p.add(lbl);

		int w = width  - 20;
		int h = height - 95;
		lusers.setBackground(Color.WHITE);
		Color color = new Color(0x44, 0x66, 0xBB);
		lusers.setBorder(javax.swing.BorderFactory.createLineBorder(color));
		lusers.setSelectionForeground(Color.YELLOW);
		lusers.setSelectionBackground(color);

		spane.setPreferredSize(new Dimension(w, h));
		p.add(spane);
		spane.getViewport().add(lusers, null);

		bselect.setPreferredSize(new Dimension(130, bselect.getFont().getSize() * 2));
		ActionListener ebut = new ActionListener(){
			public void actionPerformed(ActionEvent e){
				knDlgUsers.this.button_command(e.getActionCommand());
			}
		};
		bselect.addActionListener(ebut);
		bselect.setActionCommand("SELECT");
		p.add(bselect);

		bnot.setPreferredSize(bselect.getPreferredSize());
		bnot.addActionListener(ebut);
		bnot.setActionCommand("CANCEL");
		p.add(bnot);

		WindowListener wl = new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				knDlgUsers.this.on_close();
			}
		};
		addWindowListener(wl);
	}

	//пуск
	public boolean execute(Frame frame, boolean center){
		bselect.setText(knForm.res.getString("SEL_BUT"));
		select_user = false;
		if(center){
			Dimension ssize = Toolkit.getDefaultToolkit().getScreenSize();
			setLocation((int)(ssize.getWidth() - getWidth())/2, (int)(ssize.getHeight() - getHeight())/2);
		} else
			setLocation(frame.getX() + (frame.getWidth() - getWidth())/2, frame.getY() + (frame.getHeight() - getHeight())/2);

		//загрузка списка игроков
		if(fpanel.get_list_users()){
			for(int i = 0; i < 70; ++i){
				try {
					Thread.sleep(knUtil.SLEEP_MSEC);
				} catch(InterruptedException e){ e.printStackTrace(); }

				int res = knUtil.result.get();
				if(res == knPanelField.ERR_GOOD_USER){ //ошибок нет
					model.clear();
					String[] arr = knUtil.strbuf.toString().split(",");
					for(int j = 0; j < arr.length; ++j)
						model.addElement(arr[j]);
					arr = null;
					lusers.setSelectedIndex(0);
					break;
				} else if(res == knPanelField.ERR_NOT_USERS){
					knForm.dlg_error.setMsgText(knForm.res.getString("ONE_USER"), Color.GREEN);
					knForm.dlg_error.execute(getX(), getY(), getWidth(), getHeight());
					return false;
				}
			}
		} else {
			knForm.dlg_error.setMsgText(knForm.res.getString("ERR_USER"), Color.RED);
			knForm.dlg_error.execute(getX(), getY(), getWidth(), getHeight());
		}
		setVisible(true);
		return select_user;
	}

	private void button_command(String cmd){
		if(cmd.compareTo("CANCEL") == 0)
			on_close();
		else if(cmd.compareTo("SELECT") == 0)
			on_select();
	}

	//выбрать пользователя
	private void on_select(){
		int index = lusers.getSelectedIndex();
		if(index == -1)
			return;

		//запрос к пользователю
		if(fpanel.to_user_game((String)lusers.getSelectedValue())){
			bselect.setEnabled(false);
			lusers.setEnabled(false);
			bnot.setEnabled(false);
			bselect.setText(knForm.res.getString("WAIT_USER"));
		} else {
			knForm.dlg_error.setMsgText(knForm.res.getString("ERR_USER"), Color.RED);
			knForm.dlg_error.execute(getX(), getY(), getWidth(), getHeight());
		}
	}

	//ответ от удалённого пользователя
	public void success_result(){
		bselect.setText(knForm.res.getString("SEL_BUT"));
		bselect.setEnabled(true);
		bnot.setEnabled(true);
		lusers.setEnabled(true);		
		
		int index = lusers.getSelectedIndex();
		if(index == -1)
			return;

		switch(knUtil.result.get()){
		case knPanelField.ERR_GOOD_USER:
			select_user = true;
			bselect.setEnabled(true);
			setVisible(false);
			break;
		case knPanelField.ERR_BUSY_USER:
			model.remove(index);
			knForm.dlg_error.setMsgText(String.format(knForm.res.getString("BUSY_USER"), (String)lusers.getSelectedValue()), Color.RED);
			knForm.dlg_error.execute(getX(), getY(), getWidth(), getHeight());
			break;
		case knPanelField.ERR_FINALIZE_USER:
			model.remove(index);
			knForm.dlg_error.setMsgText(String.format(knForm.res.getString("FINALIZE_USER"), (String)lusers.getSelectedValue()), Color.RED);
			knForm.dlg_error.execute(getX(), getY(), getWidth(), getHeight());
			break;
		}
	}

	private void on_close(){
		bselect.setEnabled(true);
		bnot.setEnabled(true);
		lusers.setEnabled(true);
		select_user = false;
		setVisible(false);
	}

	public JList getList(){
		return lusers;
	}
}
