namespace GuessWordGame
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblLogin = new MetroFramework.Controls.MetroTextBox();
            this.lblPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btLogIn = new MetroFramework.Controls.MetroButton();
            this.btSignUp = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(152, 122);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Логін:";
            // 
            // lblLogin
            // 
            this.lblLogin.Location = new System.Drawing.Point(215, 122);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(158, 23);
            this.lblLogin.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(215, 162);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.PasswordChar = '*';
            this.lblPassword.Size = new System.Drawing.Size(158, 23);
            this.lblPassword.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(152, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Пароль:";
            // 
            // btLogIn
            // 
            this.btLogIn.Location = new System.Drawing.Point(260, 202);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(75, 23);
            this.btLogIn.TabIndex = 4;
            this.btLogIn.Text = "Увійти";
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // btSignUp
            // 
            this.btSignUp.Location = new System.Drawing.Point(437, 296);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(103, 23);
            this.btSignUp.TabIndex = 5;
            this.btSignUp.Text = "Зареєструватись";
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 342);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "GuessWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox lblLogin;
        private MetroFramework.Controls.MetroTextBox lblPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btLogIn;
        private MetroFramework.Controls.MetroButton btSignUp;
    }
}