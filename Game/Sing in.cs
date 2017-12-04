using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Drawing.Drawing2D;
using System.Threading;


namespace Game
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Cyan300, Accent.Cyan100, TextShade.WHITE);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Thread gamesesion = new Thread(new ThreadStart(StartGame));
            gamesesion.Start();
            //Application.Exit();

        }
      
        public void StartGame()
        {
             this.Invoke(new Action(() =>
            {
                new GameGuess().Show();
            }));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application
        }
    }
        
    }



