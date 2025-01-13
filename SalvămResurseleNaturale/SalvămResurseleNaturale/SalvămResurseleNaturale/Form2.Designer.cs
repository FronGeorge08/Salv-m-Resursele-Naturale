namespace SalvămResurseleNaturale
{
    partial class Form2
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
            label1 = new Label();
            Textbox = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(379, 76);
            label1.Name = "label1";
            label1.Size = new Size(586, 91);
            label1.TabIndex = 0;
            label1.Text = "MAIN MENIU";
            // 
            // Textbox
            // 
            Textbox.BackColor = Color.FromArgb(192, 192, 255);
            Textbox.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Textbox.Location = new Point(997, 95);
            Textbox.Multiline = true;
            Textbox.Name = "Textbox";
            Textbox.ReadOnly = true;
            Textbox.Size = new Size(356, 359);
            Textbox.TabIndex = 1;
            Textbox.TextAlign = HorizontalAlignment.Center;
            Textbox.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(171, 499);
            button1.Name = "button1";
            button1.Size = new Size(412, 142);
            button1.TabIndex = 2;
            button1.Text = "Rock-Paper-Scissors";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 447);
            label2.Name = "label2";
            label2.Size = new Size(584, 35);
            label2.TabIndex = 3;
            label2.Text = "LET'S PLAY ROCK-PAPER-SCISSORS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1106, 32);
            label3.Name = "label3";
            label3.Size = new Size(130, 46);
            label3.TabIndex = 5;
            label3.Text = "CITATE";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Screenshot_2025_01_13_100237;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1038, 519);
            button3.Name = "button3";
            button3.Size = new Size(286, 112);
            button3.TabIndex = 7;
            button3.Text = "CLOSE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rotated_image__1__removebg_preview;
            pictureBox1.Location = new Point(417, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 245);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image_2025_01_13_113414825_removebg_preview;
            pictureBox2.Location = new Point(-4, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(415, 390);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1375, 706);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(Textbox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form2";
            Text = "GreenBridge";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Textbox;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}