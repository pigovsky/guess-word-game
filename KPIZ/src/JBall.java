import java.awt.*;
import javax.swing.*;
 
public class JBall extends JPanel {

  int width;
  int height;

  float radius = 40; 
  float diameter = radius * 2;

  float X = radius + 50;
  float Y = radius + 20;
 
  float dx = 3;
  float dy = 3;
 
  public JBall() {
 
    Thread thread = new Thread() {
      public void run() {
        while (true) {
 
          width = getWidth();
          height = getHeight();
 
          X = X + dx ;
          Y = Y + dy;
 
          if (X - radius < 0) {
            dx = -dx; 
            X = radius; 
          } else if (X + radius > width) {
            dx = -dx;
            X = width - radius;
          }
 
          if (Y - radius < 0) {
            dy = -dy;
            Y = radius;
          } else if (Y + radius > height) {
            dy = -dy;
            Y = height - radius;
          }
          repaint();
 
          try {
            Thread.sleep(25);
          } catch (InterruptedException ex) {
          }
 
        }
      }
    };
    thread.start();
  }
 
  public void paintComponent(Graphics g) {
    super.paintComponent(g);
    g.setColor(Color.pink);
    g.fillOval((int)(X-radius), (int)(Y-radius), (int)diameter, (int)diameter);
  }
 
  public static void main(String[] args) {
    JFrame.setDefaultLookAndFeelDecorated(true);
    JFrame frame = new JFrame("Jumping Ball");
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setSize(800, 600);
    frame.setContentPane(new JBall());
    frame.setVisible(true);
  }
}