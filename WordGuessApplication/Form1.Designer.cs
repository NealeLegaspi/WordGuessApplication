namespace WordGuessApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lb_guess_word = new Label();
            tb_answer = new TextBox();
            tb_guess = new Button();
            label2 = new Label();
            lst_wrong_guess = new ListBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // lb_guess_word
            // 
            resources.ApplyResources(lb_guess_word, "lb_guess_word");
            lb_guess_word.Name = "lb_guess_word";
            // 
            // tb_answer
            // 
            resources.ApplyResources(tb_answer, "tb_answer");
            tb_answer.Name = "tb_answer";
            // 
            // tb_guess
            // 
            tb_guess.BackColor = Color.DarkSeaGreen;
            resources.ApplyResources(tb_guess, "tb_guess");
            tb_guess.ForeColor = Color.White;
            tb_guess.Name = "tb_guess";
            tb_guess.UseVisualStyleBackColor = false;
            tb_guess.Click += tb_guess_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // lst_wrong_guess
            // 
            lst_wrong_guess.FormattingEnabled = true;
            resources.ApplyResources(lst_wrong_guess, "lst_wrong_guess");
            lst_wrong_guess.Name = "lst_wrong_guess";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lst_wrong_guess);
            Controls.Add(label2);
            Controls.Add(tb_guess);
            Controls.Add(tb_answer);
            Controls.Add(lb_guess_word);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_guess_word;
        private TextBox tb_answer;
        private Button tb_guess;
        private Label label2;
        private ListBox lst_wrong_guess;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
