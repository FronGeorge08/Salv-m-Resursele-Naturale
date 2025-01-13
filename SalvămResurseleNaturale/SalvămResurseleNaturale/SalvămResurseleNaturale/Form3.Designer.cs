namespace SalvămResurseleNaturale
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Rock = new Button();
            Papper = new Button();
            Scissors = new Button();
            Life = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Rock
            // 
            Rock.Location = new Point(749, 420);
            Rock.Name = "Rock";
            Rock.Size = new Size(168, 235);
            Rock.TabIndex = 0;
            Rock.Text = "Rock";
            Rock.UseVisualStyleBackColor = true;
            Rock.Click += Select_Click;
            // 
            // Papper
            // 
            Papper.Location = new Point(923, 420);
            Papper.Name = "Papper";
            Papper.Size = new Size(168, 235);
            Papper.TabIndex = 1;
            Papper.Text = "Paper";
            Papper.UseVisualStyleBackColor = true;
            Papper.Click += Select_Click;
            // 
            // Scissors
            // 
            Scissors.Location = new Point(1097, 420);
            Scissors.Name = "Scissors";
            Scissors.Size = new Size(168, 235);
            Scissors.TabIndex = 2;
            Scissors.Text = "Scissors";
            Scissors.UseVisualStyleBackColor = true;
            Scissors.Click += Select_Click;
            // 
            // Life
            // 
            Life.AutoSize = true;
            Life.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Life.Location = new Point(1054, 146);
            Life.Name = "Life";
            Life.Size = new Size(49, 60);
            Life.TabIndex = 3;
            Life.Text = "5";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1131, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(115, 545);
            button1.Name = "button1";
            button1.Size = new Size(212, 82);
            button1.TabIndex = 5;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 10.2F);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(807, 20);
            label1.TabIndex = 6;
            label1.Text = "RULES:SELECT WHICH YOU WANT TO SELECT. THE BOT WILL CHOOSE AUTOMATICALLY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 10.2F);
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(1158, 20);
            label2.TabIndex = 7;
            label2.Text = "IF YOU LOSE, IT WILL APPEAR A QUESTION THAT YOU NEED TO ANSWER . IF YOU DON'T ANSWER CORECTLY, YOU LOSE A LIFE";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(73, 123);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(329, 297);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(158, 88);
            label3.Name = "label3";
            label3.Size = new Size(169, 32);
            label3.TabIndex = 9;
            label3.Text = "Curiosities";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1277, 667);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(Life);
            Controls.Add(Scissors);
            Controls.Add(Papper);
            Controls.Add(Rock);
            Name = "Form3";
            Text = "Rock-Paper-Scissors";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Rock;
        private Button Papper;
        private Button Scissors;
        private PictureBox pictureBox1;
        private Button button1;
        public Label Life;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
    }
}