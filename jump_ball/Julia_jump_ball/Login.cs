using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace howto_bouncing_ball
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox1.Text;
            MessageBox.Show("Доброго дня, " + a + "!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Julia_jump_ball.Form1 form = new Julia_jump_ball.Form1();
            form.Show();
           this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
