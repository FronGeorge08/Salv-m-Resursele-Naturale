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
    public partial class Trivia : Form
    {
        int life = 5;

        int qustionSelect;

        bool[] questionAnswers = { true, false, false };


        string[] qustions = { "Turning off lights when you leave a room helps conserve energy." ,
                              "Plastic is a renewable resource." ,
                              "The majority of Earth's water is freshwater that humans can use." };
        public Trivia()
        {
            InitializeComponent();
        }

        private void Trivia_Load(object sender, EventArgs e)
        {
            Done.Visible = false;

            Random random = new Random();

            switch (random.Next(0, 2))
            {
                case 0:
                    Question.Text = qustions[0];
                    qustionSelect = 0;
                    break;
                case 1:
                    qustionSelect = 1;
                    Question.Text = qustions[1];
                    break;
                case 2:
                    qustionSelect = 2;
                    Question.Text = qustions[2];
                    break;
            }
        }
        private void Select_Click(object sender, EventArgs e)
        {
            switch (qustionSelect)
            {
                case 0:
                    if (sender == True)
                    {
                        Question.Text = "Corect";
                    }
                    else
                    {
                        Question.Text = "Wrong";
                    }

                    Done.Visible = true;

                    break;

                case 1:
                    if (sender == False)
                    {
                        Question.Text = "Corect";
                    }
                    else
                    {
                        Question.Text = "Wrong";

                    }

                    Done.Visible = true;
                    break;

                case 2:
                    if (sender == False)
                    {
                        Question.Text = "Corect";
                    }
                    else
                    {
                        Question.Text = "Wrong";
                    }

                    Done.Visible = true;

                    break;
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Question_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
