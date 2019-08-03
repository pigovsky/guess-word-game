namespace Pocket_Navigation
{
    partial class SygicTruckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SygicTruckForm));
            this.Back_Program = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
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
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SygicTruckapkCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SygicTruckInstructionCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SygicTruckBaseMapsCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SygicTruckVoicesCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SygicTruckSpeedCamCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SygicTruckAsiaCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SygicTruckTruckEuropeCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SygicTruckUkraineMapCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblProgress = new System.Windows.Forms.Label();
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
            // btnDownload
            // 
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(619, 1);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(174, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Завантажити";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.Download_File_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Controls.Add(this.Back_Program);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 49);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Вiдмiнити ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Micra", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(270, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(273, 11);
            this.lblStatus.TabIndex = 55;
            this.lblStatus.Text = "Status: waiting for download...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 54);
            this.label1.TabIndex = 4;
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
            this.panel3.TabIndex = 12;
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
            this.bunifuElipseInfoProgressBar1.ElipseRadius = 17;
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
            this.bunifuProgressBar1.Size = new System.Drawing.Size(770, 18);
            this.bunifuProgressBar1.TabIndex = 49;
            this.bunifuProgressBar1.Value = 0;
            this.bunifuProgressBar1.progressChanged += new System.EventHandler(this.bunifuProgressBar1_progressChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pocket_Navigation.Properties.Resources.Саджек;
            this.pictureBox3.Location = new System.Drawing.Point(307, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 320);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pocket_Navigation.Properties.Resources.Без_назви_11;
            this.pictureBox1.Location = new System.Drawing.Point(24, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(48, 150);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(194, 15);
            this.bunifuCustomLabel2.TabIndex = 20;
            this.bunifuCustomLabel2.Text = "Sygic Truck apk";
            // 
            // SygicTruckapkCheckbox1
            // 
            this.SygicTruckapkCheckbox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckapkCheckbox1.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckapkCheckbox1.Checked = false;
            this.SygicTruckapkCheckbox1.CheckedOnColor = System.Drawing.Color.Tomato;
            this.SygicTruckapkCheckbox1.ForeColor = System.Drawing.Color.White;
            this.SygicTruckapkCheckbox1.Location = new System.Drawing.Point(24, 148);
            this.SygicTruckapkCheckbox1.Name = "SygicTruckapkCheckbox1";
            this.SygicTruckapkCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.SygicTruckapkCheckbox1.TabIndex = 19;
            this.SygicTruckapkCheckbox1.Tag = "";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(48, 349);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(127, 15);
            this.bunifuCustomLabel5.TabIndex = 48;
            this.bunifuCustomLabel5.Text = "Iнструкцiя";
            // 
            // SygicTruckInstructionCheckbox1
            // 
            this.SygicTruckInstructionCheckbox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckInstructionCheckbox1.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckInstructionCheckbox1.Checked = false;
            this.SygicTruckInstructionCheckbox1.CheckedOnColor = System.Drawing.Color.Tomato;
            this.SygicTruckInstructionCheckbox1.ForeColor = System.Drawing.Color.White;
            this.SygicTruckInstructionCheckbox1.Location = new System.Drawing.Point(24, 347);
            this.SygicTruckInstructionCheckbox1.Name = "SygicTruckInstructionCheckbox1";
            this.SygicTruckInstructionCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.SygicTruckInstructionCheckbox1.TabIndex = 47;
            this.SygicTruckInstructionCheckbox1.Tag = "";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(48, 193);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(116, 15);
            this.bunifuCustomLabel9.TabIndex = 46;
            this.bunifuCustomLabel9.Text = "Base Map";
            // 
            // SygicTruckBaseMapsCheckbox1
            // 
            this.SygicTruckBaseMapsCheckbox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckBaseMapsCheckbox1.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckBaseMapsCheckbox1.Checked = false;
            this.SygicTruckBaseMapsCheckbox1.CheckedOnColor = System.Drawing.Color.Tomato;
            this.SygicTruckBaseMapsCheckbox1.ForeColor = System.Drawing.Color.White;
            this.SygicTruckBaseMapsCheckbox1.Location = new System.Drawing.Point(24, 191);
            this.SygicTruckBaseMapsCheckbox1.Name = "SygicTruckBaseMapsCheckbox1";
            this.SygicTruckBaseMapsCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.SygicTruckBaseMapsCheckbox1.TabIndex = 45;
            this.SygicTruckBaseMapsCheckbox1.Tag = "";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(48, 323);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(81, 15);
            this.bunifuCustomLabel10.TabIndex = 44;
            this.bunifuCustomLabel10.Text = "Voices";
            // 
            // SygicTruckVoicesCheckbox1
            // 
            this.SygicTruckVoicesCheckbox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckVoicesCheckbox1.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckVoicesCheckbox1.Checked = false;
            this.SygicTruckVoicesCheckbox1.CheckedOnColor = System.Drawing.Color.Tomato;
            this.SygicTruckVoicesCheckbox1.ForeColor = System.Drawing.Color.White;
            this.SygicTruckVoicesCheckbox1.Location = new System.Drawing.Point(24, 321);
            this.SygicTruckVoicesCheckbox1.Name = "SygicTruckVoicesCheckbox1";
            this.SygicTruckVoicesCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.SygicTruckVoicesCheckbox1.TabIndex = 43;
            this.SygicTruckVoicesCheckbox1.Tag = "";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(48, 297);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(123, 15);
            this.bunifuCustomLabel11.TabIndex = 42;
            this.bunifuCustomLabel11.Text = "Speedcam";
            // 
            // SygicTruckSpeedCamCheckbox1
            // 
            this.SygicTruckSpeedCamCheckbox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckSpeedCamCheckbox1.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckSpeedCamCheckbox1.Checked = false;
            this.SygicTruckSpeedCamCheckbox1.CheckedOnColor = System.Drawing.Color.Tomato;
            this.SygicTruckSpeedCamCheckbox1.ForeColor = System.Drawing.Color.White;
            this.SygicTruckSpeedCamCheckbox1.Location = new System.Drawing.Point(24, 295);
            this.SygicTruckSpeedCamCheckbox1.Name = "SygicTruckSpeedCamCheckbox1";
            this.SygicTruckSpeedCamCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.SygicTruckSpeedCamCheckbox1.TabIndex = 41;
            this.SygicTruckSpeedCamCheckbox1.Tag = "";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(48, 271);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(53, 15);
            this.bunifuCustomLabel12.TabIndex = 40;
            this.bunifuCustomLabel12.Text = "Asia";
            // 
            // SygicTruckAsiaCheckbox1
            // 
            this.SygicTruckAsiaCheckbox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckAsiaCheckbox1.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckAsiaCheckbox1.Checked = false;
            this.SygicTruckAsiaCheckbox1.CheckedOnColor = System.Drawing.Color.Tomato;
            this.SygicTruckAsiaCheckbox1.ForeColor = System.Drawing.Color.White;
            this.SygicTruckAsiaCheckbox1.Location = new System.Drawing.Point(24, 269);
            this.SygicTruckAsiaCheckbox1.Name = "SygicTruckAsiaCheckbox1";
            this.SygicTruckAsiaCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.SygicTruckAsiaCheckbox1.TabIndex = 39;
            this.SygicTruckAsiaCheckbox1.Tag = "";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(48, 245);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(167, 15);
            this.bunifuCustomLabel13.TabIndex = 38;
            this.bunifuCustomLabel13.Text = "Truck Europe";
            // 
            // SygicTruckTruckEuropeCheckbox1
            // 
            this.SygicTruckTruckEuropeCheckbox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckTruckEuropeCheckbox1.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckTruckEuropeCheckbox1.Checked = false;
            this.SygicTruckTruckEuropeCheckbox1.CheckedOnColor = System.Drawing.Color.Tomato;
            this.SygicTruckTruckEuropeCheckbox1.ForeColor = System.Drawing.Color.White;
            this.SygicTruckTruckEuropeCheckbox1.Location = new System.Drawing.Point(24, 243);
            this.SygicTruckTruckEuropeCheckbox1.Name = "SygicTruckTruckEuropeCheckbox1";
            this.SygicTruckTruckEuropeCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.SygicTruckTruckEuropeCheckbox1.TabIndex = 37;
            this.SygicTruckTruckEuropeCheckbox1.Tag = "";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Micra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(48, 219);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(97, 15);
            this.bunifuCustomLabel14.TabIndex = 36;
            this.bunifuCustomLabel14.Text = "Ukraine";
            // 
            // SygicTruckUkraineMapCheckbox1
            // 
            this.SygicTruckUkraineMapCheckbox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckUkraineMapCheckbox1.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.SygicTruckUkraineMapCheckbox1.Checked = false;
            this.SygicTruckUkraineMapCheckbox1.CheckedOnColor = System.Drawing.Color.Tomato;
            this.SygicTruckUkraineMapCheckbox1.ForeColor = System.Drawing.Color.White;
            this.SygicTruckUkraineMapCheckbox1.Location = new System.Drawing.Point(24, 217);
            this.SygicTruckUkraineMapCheckbox1.Name = "SygicTruckUkraineMapCheckbox1";
            this.SygicTruckUkraineMapCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.SygicTruckUkraineMapCheckbox1.TabIndex = 35;
            this.SygicTruckUkraineMapCheckbox1.Tag = "";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Micra", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(108, 130);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(537, 11);
            this.lblProgress.TabIndex = 56;
            this.lblProgress.Text = "Progress: downloaded 0.00 MB (0 bytes) of 0.00 MB (0 bytes) 0%";
            // 
            // SygicTruckForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(795, 560);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.SygicTruckInstructionCheckbox1);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.SygicTruckBaseMapsCheckbox1);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.SygicTruckVoicesCheckbox1);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.SygicTruckSpeedCamCheckbox1);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.SygicTruckAsiaCheckbox1);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.SygicTruckTruckEuropeCheckbox1);
            this.Controls.Add(this.bunifuCustomLabel14);
            this.Controls.Add(this.SygicTruckUkraineMapCheckbox1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.SygicTruckapkCheckbox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SygicTruckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " bv";
            this.Load += new System.EventHandler(this.SygicTruckForm_Load);
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
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Exit_Program;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button HideForm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseInfoProgressBar1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCheckbox SygicTruckapkCheckbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCheckbox SygicTruckInstructionCheckbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCheckbox SygicTruckBaseMapsCheckbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCheckbox SygicTruckVoicesCheckbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCheckbox SygicTruckSpeedCamCheckbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCheckbox SygicTruckAsiaCheckbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCheckbox SygicTruckTruckEuropeCheckbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCheckbox SygicTruckUkraineMapCheckbox1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCancel;
    }
}