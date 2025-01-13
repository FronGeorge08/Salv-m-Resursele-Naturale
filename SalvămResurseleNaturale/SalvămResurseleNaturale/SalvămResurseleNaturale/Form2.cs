using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalvămResurseleNaturale
{
    public partial class Form2 : Form
    {
        string[] citate = { "Natural resources are our common heritage. Every small step to save them is a big step for the future of the planet.",
            "By conserving resources today, we invest in a greener and more sustainable tomorrow.",
            "Earth's resources are not infinite. Learn to consume wisely, so there’s enough left for future generations.",
            "A economisi resursele naturale nu este doar o opțiune, ci o responsabilitate pe care o avem față de planetă și de cei care vin după noi."};
        Random Random = new Random();
        public Form2()
        {
            InitializeComponent();
            Textbox.Text = citate[Random.Next(0, citate.Length)];
            button1.MouseEnter += (s, e) => button1.BackColor = Color.LightGreen;
            button1.MouseLeave += (s, e) => button1.BackColor = Color.LightBlue;
            button3.MouseEnter += (s, e) => button3.BackColor = Color.LightGreen;
            button3.MouseLeave += (s, e) => button3.BackColor = Color.LightBlue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
