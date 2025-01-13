using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalvămResurseleNaturale
{
    public partial class Form3 : Form
    {
        Random Random1= new Random();
        string[] citate = {"Energy conservation helps reduce the demand for fossil fuels like coal, oil, and natural gas. By reducing energy consumption, we lower greenhouse gas emissions, which contribute to climate change.",
            "Freshwater resources are limited. Overuse and pollution of water sources can lead to water shortages, affecting drinking water supplies, agriculture, and ecosystems.\r\n",
            "Forests provide oxygen, support biodiversity, and regulate climate. Deforestation contributes to habitat loss, carbon emissions, and climate change.",
            "Landfills take up space and contribute to pollution. Reducing waste helps conserve raw materials and reduces the environmental impact of waste disposal.\r\n",
            "Overuse of chemical fertilizers, pesticides, and excessive land cultivation can degrade soil, water resources, and biodiversity." };
        public Form3()
        {
            InitializeComponent();
            textBox1.Text =citate[Random1.Next(0, citate.Length)]; ;
        }

        enum SelectState
        {
            none,
            rock,
            papper,
            scissors,
        }

        private void Select_Click(object sender, EventArgs e)
        {

            void ShowTrivia()
            {
                Trivia trivia = new Trivia();
                trivia.Show();
            }

            SelectState selectState = SelectState.none;

            if (sender == Rock)
            {
                selectState = SelectState.rock;
            }
            else if (sender == Papper)
            {
                selectState = SelectState.papper;
            }
            else
            {
                selectState = SelectState.scissors;
            }

            Random random = new Random();

            int botSelect = random.Next(0, 2);

            switch (botSelect)
            {
                case 0:
                    switch (selectState)
                    {
                        case SelectState.rock:
                            MessageBox.Show("Draw");
                            break;
                        case SelectState.papper:
                            MessageBox.Show("You Lose");
                            ShowTrivia();
                            break;
                        default:
                            MessageBox.Show("You Win!");
                            break;
                    }
                    break;
                case 1:
                    switch (selectState)
                    {
                        case SelectState.papper:
                            MessageBox.Show("Draw");
                            break;
                        case SelectState.rock:
                            MessageBox.Show("You Lose");
                            ShowTrivia();
                            break;
                        default:
                            MessageBox.Show("You Win!");
                            break;
                    }
                    break;
                case 2:
                    switch (selectState)
                    {
                        case SelectState.scissors:
                            MessageBox.Show("Draw");
                            break;
                        case SelectState.rock:
                            MessageBox.Show("You Lose");
                            ShowTrivia();
                            break;
                        default:
                            MessageBox.Show("You Win!");
                            break;
                    }
                    break;
            }
        }

        private void Life_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
