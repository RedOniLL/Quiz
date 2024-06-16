namespace Quiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblScore = new Label();
            lblQuestion = new Label();
            rbOption1 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption3 = new RadioButton();
            rbOption4 = new RadioButton();
            btnNext = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(10, 7);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(147, 15);
            lblScore.TabIndex = 0;
            lblScore.Text = "Правильних відповідей: 0";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(10, 29);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(0, 15);
            lblQuestion.TabIndex = 1;
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.Location = new Point(10, 52);
            rbOption1.Margin = new Padding(3, 2, 3, 2);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(14, 13);
            rbOption1.TabIndex = 2;
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.Location = new Point(10, 74);
            rbOption2.Margin = new Padding(3, 2, 3, 2);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(14, 13);
            rbOption2.TabIndex = 3;
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.Location = new Point(10, 97);
            rbOption3.Margin = new Padding(3, 2, 3, 2);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(14, 13);
            rbOption3.TabIndex = 4;
            // 
            // rbOption4
            // 
            rbOption4.AutoSize = true;
            rbOption4.Location = new Point(10, 119);
            rbOption4.Margin = new Padding(3, 2, 3, 2);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(14, 13);
            rbOption4.TabIndex = 5;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(10, 142);
            btnNext.Margin = new Padding(3, 2, 3, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(88, 22);
            btnNext.TabIndex = 6;
            btnNext.Text = "Далі";
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 215);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 7;
            label1.Text = "Що почати натисніть \"Далі\"";
            // 
            // Form1
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(label1);
            Controls.Add(lblScore);
            Controls.Add(lblQuestion);
            Controls.Add(rbOption1);
            Controls.Add(rbOption2);
            Controls.Add(rbOption3);
            Controls.Add(rbOption4);
            Controls.Add(btnNext);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Вікторина";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbOption1;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.Button btnNext;

        #endregion

        private Label label1;
    }
}
