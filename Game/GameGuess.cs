using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using MaterialSkin;

namespace Game
{
    
    public partial class GameGuess : MaterialSkin.Controls.MaterialForm
    {
        Game game;
        Random rand = new Random();
        public GameGuess()
        {
            
            InitializeComponent();
            game = new Game();
            game.StringSplitter();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Cyan300, Accent.Cyan100, TextShade.WHITE);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            FormCloused += close;

        }
        public delegate void ClouseForm();
        public static event ClouseForm FormCloused;
        private void close()
        {
            Application.Exit();
        }

        private void GameGuess_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == game.GetAnsver(game.curentQuestion))
            {
                game.score += 100;
            }
            else
            {
                MessageBox.Show("Pussy answer");
                game.score -= 50;
            }
            game.usedQuestion.Add(game.curentQuestion);
            bool unique = false;
            while (unique == false)
            {
                unique = true;
                game.curentQuestion = rand.Next(0, game.GetSize());
                foreach (var que in game.usedQuestion)
                {
                    if (game.curentQuestion == que)
                        unique = false;
                }
            }
            if (game.round < 10)
            {
                game.round++;
                label1.Text = game.GetQuestion(game.curentQuestion);
                textBox1.Text = "\0";
            }
            else
            {
                
                MessageBox.Show("Game is over, your score:"+Convert.ToString(game.score));
            }

                }
        bool end = false;
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!end)
            {
                panel1.Visible = true;
                game.round = 1;
                game.curentQuestion = rand.Next(0, game.GetSize());
                label1.Text = game.GetQuestion(game.curentQuestion);
                StartButton.Text = "Exit";
                end = true;
            }
            else
            {
                FormCloused ();
              

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
