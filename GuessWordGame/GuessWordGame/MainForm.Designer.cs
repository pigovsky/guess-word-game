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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.btVerify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tboxGuessWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFirstLastLetter = new System.Windows.Forms.Label();
            this.btHalfWord = new System.Windows.Forms.Button();
            this.btFirstLastLetters = new System.Windows.Forms.Button();
            this.lblHalfWord = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblScore});
            this.statusStrip1.Location = new System.Drawing.Point(0, 288);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(667, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.UseWaitCursor = true;
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
            // btVerify
            // 
            this.btVerify.Location = new System.Drawing.Point(270, 199);
            this.btVerify.Name = "btVerify";
            this.btVerify.Size = new System.Drawing.Size(75, 23);
            this.btVerify.TabIndex = 1;
            this.btVerify.Text = "Перевірити";
            this.btVerify.UseVisualStyleBackColor = true;
            this.btVerify.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Питання:";
            this.label1.UseWaitCursor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(301, 60);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(0, 13);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.UseWaitCursor = true;
            // 
            // tboxGuessWord
            // 
            this.tboxGuessWord.Location = new System.Drawing.Point(291, 128);
            this.tboxGuessWord.Name = "tboxGuessWord";
            this.tboxGuessWord.Size = new System.Drawing.Size(100, 20);
            this.tboxGuessWord.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Слово:";
            // 
            // lblFirstLastLetter
            // 
            this.lblFirstLastLetter.AutoSize = true;
            this.lblFirstLastLetter.Location = new System.Drawing.Point(87, 180);
            this.lblFirstLastLetter.Name = "lblFirstLastLetter";
            this.lblFirstLastLetter.Size = new System.Drawing.Size(35, 13);
            this.lblFirstLastLetter.TabIndex = 6;
            this.lblFirstLastLetter.Text = "label3";
            // 
            // btHalfWord
            // 
            this.btHalfWord.Location = new System.Drawing.Point(485, 36);
            this.btHalfWord.Name = "btHalfWord";
            this.btHalfWord.Size = new System.Drawing.Size(75, 37);
            this.btHalfWord.TabIndex = 8;
            this.btHalfWord.Text = "Половина слова";
            this.btHalfWord.UseVisualStyleBackColor = true;
            // 
            // btFirstLastLetters
            // 
            this.btFirstLastLetters.Location = new System.Drawing.Point(566, 36);
            this.btFirstLastLetters.Name = "btFirstLastLetters";
            this.btFirstLastLetters.Size = new System.Drawing.Size(75, 48);
            this.btFirstLastLetters.TabIndex = 9;
            this.btFirstLastLetters.Text = "Перша і остання літера";
            this.btFirstLastLetters.UseVisualStyleBackColor = true;
            // 
            // lblHalfWord
            // 
            this.lblHalfWord.AutoSize = true;
            this.lblHalfWord.Location = new System.Drawing.Point(62, 242);
            this.lblHalfWord.Name = "lblHalfWord";
            this.lblHalfWord.Size = new System.Drawing.Size(35, 13);
            this.lblHalfWord.TabIndex = 10;
            this.lblHalfWord.Text = "label5";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 310);
            this.Controls.Add(this.lblHalfWord);
            this.Controls.Add(this.btFirstLastLetters);
            this.Controls.Add(this.btHalfWord);
            this.Controls.Add(this.lblFirstLastLetter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxGuessWord);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVerify);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Guess Word";
            this.UseWaitCursor = true;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Label lblFirstLastLetter;
        private System.Windows.Forms.Button btHalfWord;
        private System.Windows.Forms.Button btFirstLastLetters;
        private System.Windows.Forms.Label lblHalfWord;
    }
}

