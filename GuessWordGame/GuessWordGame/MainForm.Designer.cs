namespace GuessWordGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tboxGuessWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrompts = new System.Windows.Forms.Label();
            this.rdGuessWord = new System.Windows.Forms.RadioButton();
            this.rdGuessLetters = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btFirstLastLetters = new System.Windows.Forms.Button();
            this.btHalfWord = new System.Windows.Forms.Button();
            this.btVerify = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblScore});
            this.statusStrip1.Location = new System.Drawing.Point(20, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(609, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(138, 17);
            this.toolStripStatusLabel1.Text = "Ваш поточний рахунок:";
            // 
            // lblScore
            // 
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Питання:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(117, 70);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(0, 13);
            this.lblQuestion.TabIndex = 3;
            // 
            // tboxGuessWord
            // 
            this.tboxGuessWord.Location = new System.Drawing.Point(133, 135);
            this.tboxGuessWord.Name = "tboxGuessWord";
            this.tboxGuessWord.Size = new System.Drawing.Size(202, 20);
            this.tboxGuessWord.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ваша відповідь:";
            // 
            // lblPrompts
            // 
            this.lblPrompts.AutoSize = true;
            this.lblPrompts.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompts.Location = new System.Drawing.Point(101, 184);
            this.lblPrompts.Name = "lblPrompts";
            this.lblPrompts.Size = new System.Drawing.Size(0, 12);
            this.lblPrompts.TabIndex = 6;
            // 
            // rdGuessWord
            // 
            this.rdGuessWord.AutoSize = true;
            this.rdGuessWord.Checked = true;
            this.rdGuessWord.Location = new System.Drawing.Point(21, 32);
            this.rdGuessWord.Name = "rdGuessWord";
            this.rdGuessWord.Size = new System.Drawing.Size(71, 17);
            this.rdGuessWord.TabIndex = 10;
            this.rdGuessWord.TabStop = true;
            this.rdGuessWord.Text = "По слову";
            this.rdGuessWord.UseVisualStyleBackColor = true;
            this.rdGuessWord.CheckedChanged += new System.EventHandler(this.rdGuessWord_CheckedChanged);
            // 
            // rdGuessLetters
            // 
            this.rdGuessLetters.AutoSize = true;
            this.rdGuessLetters.Location = new System.Drawing.Point(21, 55);
            this.rdGuessLetters.Name = "rdGuessLetters";
            this.rdGuessLetters.Size = new System.Drawing.Size(86, 17);
            this.rdGuessLetters.TabIndex = 11;
            this.rdGuessLetters.TabStop = true;
            this.rdGuessLetters.Text = "За літерами";
            this.rdGuessLetters.UseVisualStyleBackColor = true;
            this.rdGuessLetters.CheckedChanged += new System.EventHandler(this.rdGuessLetters_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdGuessWord);
            this.groupBox1.Controls.Add(this.rdGuessLetters);
            this.groupBox1.Location = new System.Drawing.Point(418, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Виберіть тип вгадування";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Половина слова";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btFirstLastLetters);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btHalfWord);
            this.groupBox2.Location = new System.Drawing.Point(409, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 122);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Підказки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Перша і\r\nостання літера";
            // 
            // btFirstLastLetters
            // 
            this.btFirstLastLetters.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFirstLastLetters.BackgroundImage = global::GuessWordGame.Properties.Resources.Ambox_blue_question_svg;
            this.btFirstLastLetters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFirstLastLetters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFirstLastLetters.Location = new System.Drawing.Point(116, 58);
            this.btFirstLastLetters.Name = "btFirstLastLetters";
            this.btFirstLastLetters.Size = new System.Drawing.Size(56, 46);
            this.btFirstLastLetters.TabIndex = 9;
            this.btFirstLastLetters.UseVisualStyleBackColor = false;
            this.btFirstLastLetters.Click += new System.EventHandler(this.btFirstLastLetters_Click);
            // 
            // btHalfWord
            // 
            this.btHalfWord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btHalfWord.BackgroundImage = global::GuessWordGame.Properties.Resources.Ambox_blue_question_svg;
            this.btHalfWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btHalfWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHalfWord.Location = new System.Drawing.Point(27, 58);
            this.btHalfWord.Name = "btHalfWord";
            this.btHalfWord.Size = new System.Drawing.Size(54, 46);
            this.btHalfWord.TabIndex = 8;
            this.btHalfWord.UseVisualStyleBackColor = false;
            this.btHalfWord.Click += new System.EventHandler(this.btHalfWord_Click);
            // 
            // btVerify
            // 
            this.btVerify.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btVerify.BackgroundImage = global::GuessWordGame.Properties.Resources.GreenTick;
            this.btVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVerify.Location = new System.Drawing.Point(222, 212);
            this.btVerify.Name = "btVerify";
            this.btVerify.Size = new System.Drawing.Size(63, 54);
            this.btVerify.TabIndex = 1;
            this.btVerify.UseVisualStyleBackColor = false;
            this.btVerify.Click += new System.EventHandler(this.btVerify_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 318);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPrompts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxGuessWord);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVerify);
            this.Controls.Add(this.statusStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Guess Word";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblScore;
        private System.Windows.Forms.Button btVerify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox tboxGuessWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrompts;
        private System.Windows.Forms.Button btHalfWord;
        private System.Windows.Forms.Button btFirstLastLetters;
        private System.Windows.Forms.RadioButton rdGuessWord;
        private System.Windows.Forms.RadioButton rdGuessLetters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
    }
}

