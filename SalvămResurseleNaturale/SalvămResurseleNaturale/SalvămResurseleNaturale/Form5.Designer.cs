namespace SalvămResurseleNaturale
{
    partial class Trivia
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
            False = new Button();
            True = new Button();
            Question = new TextBox();
            Done = new Button();
            SuspendLayout();
            // 
            // False
            // 
            False.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            False.Location = new Point(12, 321);
            False.Name = "False";
            False.Size = new Size(193, 117);
            False.TabIndex = 0;
            False.Text = "False";
            False.UseVisualStyleBackColor = true;
            False.Click += Select_Click;
            // 
            // True
            // 
            True.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            True.Location = new Point(230, 321);
            True.Name = "True";
            True.Size = new Size(187, 117);
            True.TabIndex = 1;
            True.Text = "True";
            True.UseVisualStyleBackColor = true;
            True.Click += Select_Click;
            // 
            // Question
            // 
            Question.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Question.Location = new Point(12, 12);
            Question.Multiline = true;
            Question.Name = "Question";
            Question.Size = new Size(405, 287);
            Question.TabIndex = 2;
            Question.TextChanged += Question_TextChanged;
            // 
            // Done
            // 
            Done.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Done.Location = new Point(12, 321);
            Done.Name = "Done";
            Done.Size = new Size(405, 117);
            Done.TabIndex = 3;
            Done.Text = "Done";
            Done.UseVisualStyleBackColor = true;
            Done.Click += Done_Click;
            // 
            // Trivia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(429, 450);
            Controls.Add(Done);
            Controls.Add(Question);
            Controls.Add(True);
            Controls.Add(False);
            Name = "Trivia";
            Text = "Question";
            Load += Trivia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button False;
        private Button True;
        private TextBox Question;
        private Button Done;
    }
}