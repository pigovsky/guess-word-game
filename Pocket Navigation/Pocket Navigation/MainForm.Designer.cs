namespace Pocket_Navigation
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.FacebookStor = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ActivationStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.ActivationPanel = new System.Windows.Forms.Panel();
            this.PasteBtn = new System.Windows.Forms.Button();
            this.ActivKod3 = new System.Windows.Forms.TextBox();
            this.ActivKod2 = new System.Windows.Forms.TextBox();
            this.ActivKod1 = new System.Windows.Forms.TextBox();
            this.ActivationLbl = new System.Windows.Forms.Label();
            this.ActivKod = new System.Windows.Forms.TextBox();
            this.bunifuElipseActivPanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseInfoPanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Logo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ActiveBtn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Navitel_B = new System.Windows.Forms.Button();
            this.IGOPrimo_B = new System.Windows.Forms.Button();
            this.IGONextgen_B = new System.Windows.Forms.Button();
            this.SygicTruck_B = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Setings_B = new System.Windows.Forms.Button();
            this.Addition_B = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.HideForm = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Exit_Program = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.ActivationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Setings_B);
            this.panel1.Controls.Add(this.Addition_B);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.FacebookStor);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.LinkColor = System.Drawing.Color.Tomato;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // FacebookStor
            // 
            this.FacebookStor.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.FacebookStor, "FacebookStor");
            this.FacebookStor.LinkColor = System.Drawing.Color.Tomato;
            this.FacebookStor.Name = "FacebookStor";
            this.FacebookStor.TabStop = true;
            this.FacebookStor.VisitedLinkColor = System.Drawing.Color.Red;
            this.FacebookStor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.ActivationStatus);
            this.panel2.Controls.Add(this.HideForm);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.Exit_Program);
            this.panel2.Controls.Add(this.label2);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ActivationStatus
            // 
            resources.ApplyResources(this.ActivationStatus, "ActivationStatus");
            this.ActivationStatus.BackColor = System.Drawing.Color.RoyalBlue;
            this.ActivationStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActivationStatus.ForeColor = System.Drawing.Color.Khaki;
            this.ActivationStatus.Name = "ActivationStatus";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // bunifuElipseForm
            // 
            this.bunifuElipseForm.ElipseRadius = 20;
            this.bunifuElipseForm.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.Tomato;
            this.InfoPanel.Controls.Add(this.HelpLabel);
            this.InfoPanel.Controls.Add(this.pictureBox4);
            resources.ApplyResources(this.InfoPanel, "InfoPanel");
            this.InfoPanel.Name = "InfoPanel";
            // 
            // HelpLabel
            // 
            resources.ApplyResources(this.HelpLabel, "HelpLabel");
            this.HelpLabel.ForeColor = System.Drawing.Color.White;
            this.HelpLabel.Name = "HelpLabel";
            // 
            // ActivationPanel
            // 
            this.ActivationPanel.BackColor = System.Drawing.Color.Tomato;
            this.ActivationPanel.Controls.Add(this.ClearBtn);
            this.ActivationPanel.Controls.Add(this.ActiveBtn);
            this.ActivationPanel.Controls.Add(this.PasteBtn);
            this.ActivationPanel.Controls.Add(this.ActivKod3);
            this.ActivationPanel.Controls.Add(this.ActivKod2);
            this.ActivationPanel.Controls.Add(this.ActivKod1);
            this.ActivationPanel.Controls.Add(this.ActivationLbl);
            this.ActivationPanel.Controls.Add(this.ActivKod);
            resources.ApplyResources(this.ActivationPanel, "ActivationPanel");
            this.ActivationPanel.Name = "ActivationPanel";
            this.ActivationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ActivationPanel_Paint);
            // 
            // PasteBtn
            // 
            this.PasteBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.PasteBtn, "PasteBtn");
            this.PasteBtn.ForeColor = System.Drawing.Color.White;
            this.PasteBtn.Name = "PasteBtn";
            this.PasteBtn.UseVisualStyleBackColor = true;
            this.PasteBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ActivKod3
            // 
            resources.ApplyResources(this.ActivKod3, "ActivKod3");
            this.ActivKod3.Name = "ActivKod3";
            this.ActivKod3.Tag = "";
            this.ActivKod3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ActivKod2
            // 
            resources.ApplyResources(this.ActivKod2, "ActivKod2");
            this.ActivKod2.Name = "ActivKod2";
            this.ActivKod2.Tag = "";
            // 
            // ActivKod1
            // 
            resources.ApplyResources(this.ActivKod1, "ActivKod1");
            this.ActivKod1.Name = "ActivKod1";
            this.ActivKod1.Tag = "";
            // 
            // ActivationLbl
            // 
            resources.ApplyResources(this.ActivationLbl, "ActivationLbl");
            this.ActivationLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActivationLbl.ForeColor = System.Drawing.Color.White;
            this.ActivationLbl.Name = "ActivationLbl";
            // 
            // ActivKod
            // 
            resources.ApplyResources(this.ActivKod, "ActivKod");
            this.ActivKod.Name = "ActivKod";
            this.ActivKod.Tag = "";
            this.ActivKod.TextChanged += new System.EventHandler(this.ActivKod_TextChanged);
            this.ActivKod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActivKod_KeyDown);
            // 
            // bunifuElipseActivPanel
            // 
            this.bunifuElipseActivPanel.ElipseRadius = 20;
            this.bunifuElipseActivPanel.TargetControl = this.ActivationPanel;
            // 
            // bunifuElipseInfoPanel
            // 
            this.bunifuElipseInfoPanel.ElipseRadius = 20;
            this.bunifuElipseInfoPanel.TargetControl = this.InfoPanel;
            // 
            // Logo
            // 
            this.Logo.ElipseRadius = 20;
            this.Logo.TargetControl = this.pictureBox1;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label2;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.ActivationStatus;
            this.bunifuDragControl3.Vertical = true;
            // 
            // ActiveBtn
            // 
            this.ActiveBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ActiveBtn, "ActiveBtn");
            this.ActiveBtn.ForeColor = System.Drawing.Color.White;
            this.ActiveBtn.Name = "ActiveBtn";
            this.ActiveBtn.UseVisualStyleBackColor = true;
            this.ActiveBtn.Click += new System.EventHandler(this.ActiveBtn_Click);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // Navitel_B
            // 
            resources.ApplyResources(this.Navitel_B, "Navitel_B");
            this.Navitel_B.FlatAppearance.BorderSize = 0;
            this.Navitel_B.Image = global::Pocket_Navigation.Properties.Resources.Без_назви_1Навітел;
            this.Navitel_B.Name = "Navitel_B";
            this.Navitel_B.UseVisualStyleBackColor = true;
            this.Navitel_B.Click += new System.EventHandler(this.Navitel_B_Click);
            // 
            // IGOPrimo_B
            // 
            resources.ApplyResources(this.IGOPrimo_B, "IGOPrimo_B");
            this.IGOPrimo_B.FlatAppearance.BorderSize = 0;
            this.IGOPrimo_B.Image = global::Pocket_Navigation.Properties.Resources.Без_назви_1Прімо11;
            this.IGOPrimo_B.Name = "IGOPrimo_B";
            this.IGOPrimo_B.UseVisualStyleBackColor = true;
            this.IGOPrimo_B.Click += new System.EventHandler(this.IGOPrimo_B_Click);
            // 
            // IGONextgen_B
            // 
            resources.ApplyResources(this.IGONextgen_B, "IGONextgen_B");
            this.IGONextgen_B.FlatAppearance.BorderSize = 0;
            this.IGONextgen_B.Image = global::Pocket_Navigation.Properties.Resources.Без_назви_1Некстген;
            this.IGONextgen_B.Name = "IGONextgen_B";
            this.IGONextgen_B.UseVisualStyleBackColor = true;
            this.IGONextgen_B.Click += new System.EventHandler(this.button2_Click);
            // 
            // SygicTruck_B
            // 
            resources.ApplyResources(this.SygicTruck_B, "SygicTruck_B");
            this.SygicTruck_B.FlatAppearance.BorderSize = 0;
            this.SygicTruck_B.ForeColor = System.Drawing.Color.White;
            this.SygicTruck_B.Image = global::Pocket_Navigation.Properties.Resources.Без_назви_11;
            this.SygicTruck_B.Name = "SygicTruck_B";
            this.SygicTruck_B.UseVisualStyleBackColor = true;
            this.SygicTruck_B.Click += new System.EventHandler(this.SygicTruck_B_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Pocket_Navigation.Properties.Resources.YouTube__4_;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Tomato;
            this.pictureBox1.Image = global::Pocket_Navigation.Properties.Resources.Логотип_2;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Pocket_Navigation.Properties.Resources.key;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Setings_B
            // 
            this.Setings_B.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Setings_B, "Setings_B");
            this.Setings_B.ForeColor = System.Drawing.Color.White;
            this.Setings_B.Image = global::Pocket_Navigation.Properties.Resources.Black_Settings__1_;
            this.Setings_B.Name = "Setings_B";
            this.Setings_B.UseVisualStyleBackColor = true;
            this.Setings_B.Click += new System.EventHandler(this.Setings_B_Click);
            // 
            // Addition_B
            // 
            this.Addition_B.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Addition_B, "Addition_B");
            this.Addition_B.ForeColor = System.Drawing.Color.White;
            this.Addition_B.Image = global::Pocket_Navigation.Properties.Resources.house;
            this.Addition_B.Name = "Addition_B";
            this.Addition_B.UseVisualStyleBackColor = true;
            this.Addition_B.Click += new System.EventHandler(this.Addition_B_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pocket_Navigation.Properties.Resources.facebook_pencil;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // HideForm
            // 
            this.HideForm.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.HideForm, "HideForm");
            this.HideForm.Image = global::Pocket_Navigation.Properties.Resources.remove_minus_sign_small__4_;
            this.HideForm.Name = "HideForm";
            this.HideForm.UseVisualStyleBackColor = true;
            this.HideForm.Click += new System.EventHandler(this.HideForm_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pocket_Navigation.Properties.Resources.truck;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Exit_Program
            // 
            this.Exit_Program.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Exit_Program, "Exit_Program");
            this.Exit_Program.Image = global::Pocket_Navigation.Properties.Resources.Cross_lines;
            this.Exit_Program.Name = "Exit_Program";
            this.Exit_Program.UseVisualStyleBackColor = true;
            this.Exit_Program.Click += new System.EventHandler(this.Exit_Program_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ClearBtn, "ClearBtn");
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Image = global::Pocket_Navigation.Properties.Resources.Actions_edit_clear_locationbar_rtl_icon1;
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.ActivationPanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.Navitel_B);
            this.Controls.Add(this.IGOPrimo_B);
            this.Controls.Add(this.IGONextgen_B);
            this.Controls.Add(this.SygicTruck_B);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ActivationPanel.ResumeLayout(false);
            this.ActivationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exit_Program;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel FacebookStor;
        private System.Windows.Forms.Button Setings_B;
        private System.Windows.Forms.Button Addition_B;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseForm;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ActivationPanel;
        private System.Windows.Forms.Button PasteBtn;
        private System.Windows.Forms.Label ActivationLbl;
        private System.Windows.Forms.Button HideForm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseActivPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseInfoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse Logo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button ActiveBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        public System.Windows.Forms.TextBox ActivKod3;
        public System.Windows.Forms.TextBox ActivKod2;
        public System.Windows.Forms.TextBox ActivKod1;
        public System.Windows.Forms.TextBox ActivKod;
        protected System.Windows.Forms.Label ActivationStatus;
        protected System.Windows.Forms.Button SygicTruck_B;
        protected System.Windows.Forms.Button IGONextgen_B;
        protected System.Windows.Forms.Button IGOPrimo_B;
        protected System.Windows.Forms.Button Navitel_B;
        private System.Windows.Forms.Button ClearBtn;
    }
}

