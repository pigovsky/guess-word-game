/*  Автор(с): Кудуштеев Алексей
	Для начинающих программистов
*/
package kngame;
import java.awt.Toolkit;
import javax.swing.SwingUtilities;
import javax.swing.UIManager;
import java.awt.Dimension;


//приложение
public class knAppGame {
 	boolean pframe = false;

	public knAppGame() {
		knForm frame = new knForm();
		if(pframe)
			frame.pack();
		else
			frame.validate();

		Dimension ssize = Toolkit.getDefaultToolkit().getScreenSize();
		Dimension fsize = frame.getSize();
		if(fsize.height > ssize.height)
			fsize.height = ssize.height;

		if(fsize.width > ssize.width)
			fsize.width = ssize.width;

		frame.setLocation((ssize.width - fsize.width) / 2, (ssize.height - fsize.height) / 2);
		frame.setVisible(true);
	}

	//точка входа
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable(){
			public void run() {
				try {
					UIManager.setLookAndFeel(UIManager.getCrossPlatformLookAndFeelClassName());
				} catch(Exception e) {
					e.printStackTrace();
				}
				new knAppGame();
			}
		});
	}
}
