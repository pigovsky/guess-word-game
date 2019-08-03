namespace Pocket_Navigation
{
    partial class IGONextgenForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IGONextgenForm));
            this.Back_Program = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.HideForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Exit_Program = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipseInfoProgressBar1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.InstructionsCheckbox9 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BaseMapCheckbox8 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.VoicesCheckbox7 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SpeedcamCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.AsiaCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCheckbox6 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TruckEuropeCheckbox5 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.UkraineCheckbox4 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SygicTruckapkCheckbox3 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Program
            // 
            this.Back_Program.FlatAppearance.BorderSize = 0;
            this.Back_Program.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Program.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Program.ForeColor = System.Drawing.Color.White;
            this.Back_Program.Location = new System.Drawing.Point(12, 10);
            this.Back_Program.Name = "Back_Program";
            this.Back_Program.Size = new System.Drawing.Size(115, 31);
            this.Back_Program.TabIndex = 0;
            this.Back_Program.Text = "<-- Назад";
            this.Back_Program.UseVisualStyleBackColor = true;
            this.Back_Program.Click += new System.EventHandler(this.Back_Program_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.Back_Program);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 49);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.HideForm);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.Exit_Program);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 29);
            this.panel3.TabIndex = 15;
            // 
            // HideForm
            // 
            this.HideForm.FlatAppearance.BorderSize = 0;
            this.HideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideForm.Image = global::Pocket_Navigation.Properties.Resources.remove_minus_sign_small__4_;
            this.HideForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HideForm.Location = new System.Drawing.Point(741, 5);
            this.HideForm.Name = "HideForm";
            this.HideForm.Size = new System.Drawing.Size(20, 20);
            this.HideForm.TabIndex = 8;
            this.HideForm.UseVisualStyleBackColor = true;
            this.HideForm.Click += new System.EventHandler(this.HideForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Micra", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(27, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pocket Navigation v1.0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pocket_Navigation.Properties.Resources.truck;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Exit_Program
            // 
            this.Exit_Program.FlatAppearance.BorderSize = 0;
            this.Exit_Program.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Program.Image = global::Pocket_Navigation.Properties.Resources.Cross_lines;
            this.Exit_Program.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit_Program.Location = new System.Drawing.Point(767, 5);
            this.Exit_Program.Name = "Exit_Program";
            this.Exit_Program.Size = new System.Drawing.Size(20, 20);
            this.Exit_Program.TabIndex = 6;
            this.Exit_Program.UseVisualStyleBackColor = true;
            this.Exit_Program.Click += new System.EventHandler(this.Exit_Program_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipseInfoProgressBar1
            // 
            this.bunifuElipseInfoProgressBar1.ElipseRadius = 20;
            this.bunifuElipseInfoProgressBar1.TargetControl = this.bunifuProgressBar1;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(12, 109);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Tomato;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(771, 18);
            this.bunifuProgressBar1.TabIndex = 51;
            this.bunifuProgressBar1.Value = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pocket_Navigation.Properties.Resources.Некстген_тел;
            this.pictureBox3.Location = new System.Drawing.Point(307, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 320);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pocket_Navigation.Properties.Resources.Без_назви_1Некстген;
            this.pictureBox1.Location = new System.Drawing.Point(24, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(48, 349);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(127, 15);
            this.bunifuCustomLabel8.TabIndex = 48;
            this.bunifuCustomLabel8.Text = "Iнструкцiя";
            // 
            // InstructionsCheckbox9
            // 
            this.InstructionsCheckbox9.BackColor = System.Drawing.Color.RoyalBlue;
            this.InstructionsCheckbox9.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.InstructionsCheckbox9.Checked = false;
            this.InstructionsCheckbox9.CheckedOnColor = System.Drawing.Color.Tomato;
            this.InstructionsCheckbox9.ForeColor = System.Drawing.Color.White;
            this.InstructionsCheckbox9.Location = new System.Drawing.Point(24, 347);
            this.InstructionsCheckbox9.Name = "InstructionsCheckbox9";
            this.InstructionsCheckbox9.Size = new System.Drawing.Size(20, 20);
            this.InstructionsCheckbox9.TabIndex = 47;
            this.InstructionsCheckbox9.Tag = "";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(48, 193);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(116, 15);
            this.bunifuCustomLabel7.TabIndex = 46;
            this.bunifuCustomLabel7.Text = "Base Map";
            // 
            // BaseMapCheckbox8
            // 
            this.BaseMapCheckbox8.BackColor = System.Drawing.Color.RoyalBlue;
            this.BaseMapCheckbox8.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.BaseMapCheckbox8.Checked = false;
            this.BaseMapCheckbox8.CheckedOnColor = System.Drawing.Color.Tomato;
            this.BaseMapCheckbox8.ForeColor = System.Drawing.Color.White;
            this.BaseMapCheckbox8.Location = new System.Drawing.Point(24, 191);
            this.BaseMapCheckbox8.Name = "BaseMapCheckbox8";
            this.BaseMapCheckbox8.Size = new System.Drawing.Size(20, 20);
            this.BaseMapCheckbox8.TabIndex = 45;
            this.BaseMapCheckbox8.Tag = "";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(48, 323);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(81, 15);
            this.bunifuCustomLabel6.TabIndex = 44;
            this.bunifuCustomLabel6.Text = "Voices";
            // 
            // VoicesCheckbox7
            // 
            this.VoicesCheckbox7.BackColor = System.Drawing.Color.RoyalBlue;
            this.VoicesCheckbox7.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.VoicesCheckbox7.Checked = false;
            this.VoicesCheckbox7.CheckedOnColor = System.Drawing.Color.Tomato;
            this.VoicesCheckbox7.ForeColor = System.Drawing.Color.White;
            this.VoicesCheckbox7.Location = new System.Drawing.Point(24, 321);
            this.VoicesCheckbox7.Name = "VoicesCheckbox7";
            this.VoicesCheckbox7.Size = new System.Drawing.Size(20, 20);
            this.VoicesCheckbox7.TabIndex = 43;
            this.VoicesCheckbox7.Tag = "";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(48, 297);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(123, 15);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Speedcam";
            // 
            // SpeedcamCheckbox1
            // 
            this.SpeedcamCheckbox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.SpeedcamCheckbox1.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.SpeedcamCheckbox1.Checked = false;
            this.SpeedcamCheckbox1.CheckedOnColor = System.Drawing.Color.Tomato;
            this.SpeedcamCheckbox1.ForeColor = System.Drawing.Color.White;
            this.SpeedcamCheckbox1.Location = new System.Drawing.Point(24, 295);
            this.SpeedcamCheckbox1.Name = "SpeedcamCheckbox1";
            this.SpeedcamCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.SpeedcamCheckbox1.TabIndex = 41;
            this.SpeedcamCheckbox1.Tag = "";
            // 
            // AsiaCustomLabel5
            // 
            this.AsiaCustomLabel5.AutoSize = true;
            this.AsiaCustomLabel5.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AsiaCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.AsiaCustomLabel5.Location = new System.Drawing.Point(48, 271);
            this.AsiaCustomLabel5.Name = "AsiaCustomLabel5";
            this.AsiaCustomLabel5.Size = new System.Drawing.Size(53, 15);
            this.AsiaCustomLabel5.TabIndex = 40;
            this.AsiaCustomLabel5.Text = "Asia";
            // 
            // bunifuCheckbox6
            // 
            this.bunifuCheckbox6.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCheckbox6.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCheckbox6.Checked = false;
            this.bunifuCheckbox6.CheckedOnColor = System.Drawing.Color.Tomato;
            this.bunifuCheckbox6.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox6.Location = new System.Drawing.Point(24, 269);
            this.bunifuCheckbox6.Name = "bunifuCheckbox6";
            this.bunifuCheckbox6.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox6.TabIndex = 39;
            this.bunifuCheckbox6.Tag = "";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(48, 245);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(167, 15);
            this.bunifuCustomLabel4.TabIndex = 38;
            this.bunifuCustomLabel4.Text = "Truck Europe";
            // 
            // TruckEuropeCheckbox5
            // 
            this.TruckEuropeCheckbox5.BackColor = System.Drawing.Color.RoyalBlue;
            this.TruckEuropeCheckbox5.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.TruckEuropeCheckbox5.Checked = false;
            this.TruckEuropeCheckbox5.CheckedOnColor = System.Drawing.Color.Tomato;
            this.TruckEuropeCheckbox5.ForeColor = System.Drawing.Color.White;
            this.TruckEuropeCheckbox5.Location = new System.Drawing.Point(24, 243);
            this.TruckEuropeCheckbox5.Name = "TruckEuropeCheckbox5";
            this.TruckEuropeCheckbox5.Size = new System.Drawing.Size(20, 20);
            this.TruckEuropeCheckbox5.TabIndex = 37;
            this.TruckEuropeCheckbox5.Tag = "";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(48, 219);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(97, 15);
            this.bunifuCustomLabel3.TabIndex = 36;
            this.bunifuCustomLabel3.Text = "Ukraine";
            // 
            // UkraineCheckbox4
            // 
            this.UkraineCheckbox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.UkraineCheckbox4.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.UkraineCheckbox4.Checked = false;
            this.UkraineCheckbox4.CheckedOnColor = System.Drawing.Color.Tomato;
            this.UkraineCheckbox4.ForeColor = System.Drawing.Color.White;
            this.UkraineCheckbox4.Location = new System.Drawing.Point(24, 217);
            this.UkraineCheckbox4.Name = "UkraineCheckbox4";
            this.UkraineCheckbox4.Size = new System.Drawing.Size(20, 20);
            this.UkraineCheckbox4.TabIndex = 35;
            this.UkraineCheckbox4.Tag = "";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(48, 150);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(197, 15);
            this.bunifuCustomLabel2.TabIndex = 50;
            this.bunifuCustomLabel2.Text = "IGO Nextgen apk";
            // 
            // SygicTruckapkCheckbox3
            // 
            this.SygicTruckapkCheckbox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckapkCheckbox3.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckapkCheckbox3.Checked = false;
            this.SygicTruckapkCheckbox3.CheckedOnColor = System.Drawing.Color.Tomato;
            this.SygicTruckapkCheckbox3.ForeColor = System.Drawing.Color.White;
            this.SygicTruckapkCheckbox3.Location = new System.Drawing.Point(24, 148);
            this.SygicTruckapkCheckbox3.Name = "SygicTruckapkCheckbox3";
            this.SygicTruckapkCheckbox3.Size = new System.Drawing.Size(20, 20);
            this.SygicTruckapkCheckbox3.TabIndex = 49;
            this.SygicTruckapkCheckbox3.Tag = "";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Micra", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(108, 130);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(537, 11);
            this.lblProgress.TabIndex = 60;
            this.lblProgress.Text = "Progress: downloaded 0.00 MB (0 bytes) of 0.00 MB (0 bytes) 0%";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(619, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 22);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Вiдмiнити ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Micra", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(270, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(273, 11);
            this.lblStatus.TabIndex = 59;
            this.lblStatus.Text = "Status: waiting for download...";
            // 
            // btnDownload
            // 
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(619, 1);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(174, 23);
            this.btnDownload.TabIndex = 57;
            this.btnDownload.Text = "Завантажити";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // IGONextgenForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(795, 560);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.SygicTruckapkCheckbox3);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.InstructionsCheckbox9);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.BaseMapCheckbox8);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.VoicesCheckbox7);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SpeedcamCheckbox1);
            this.Controls.Add(this.AsiaCustomLabel5);
            this.Controls.Add(this.bunifuCheckbox6);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.TruckEuropeCheckbox5);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.UkraineCheckbox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IGONextgenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IGONextgenForm";
            this.Load += new System.EventHandler(this.IGONextgenForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back_Program;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Exit_Program;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button HideForm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseInfoProgressBar1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCheckbox InstructionsCheckbox9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCheckbox BaseMapCheckbox8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCheckbox VoicesCheckbox7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox SpeedcamCheckbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel AsiaCustomLabel5;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCheckbox TruckEuropeCheckbox5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCheckbox UkraineCheckbox4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCheckbox SygicTruckapkCheckbox3;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblStatus;
    }
}