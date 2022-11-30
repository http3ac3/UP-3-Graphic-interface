using System;
using System.Windows.Forms;

namespace UP_3._3_Graphic_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void Function(double x, double a, out double y) => y = (x < a) ? 0 : (x > a) ? (x - a) / (x + a) : 1;

        private void GetTableButton_Click(object sender, EventArgs e)
        {
            AnswerBox.Text = "";

            if (!double.TryParse(AValueBox.Text, out double a))
            {
                AnswerBox.Text = "В поле а введены недопустимые значения!";
                return;
            }

            if (!double.TryParse(BValueBox.Text, out double b))
            {
                AnswerBox.Text = "В поле а введены недопустимые значения!";
                return;
            }

            if (!double.TryParse(HValueBox.Text, out double h))
            {
                AnswerBox.Text = "В поле а введены недопустимые значения!";
                return;
            }

            AnswerBox.Text += "Таблица значений\n";
            AnswerBox.Text += "x\t|\ty\n"; AnswerBox.Text += "===============\n";
            for (double x = a; x <= b; x += h)
            {
                Function(x, a, out double y);
                AnswerBox.Text += $"{x}\t|\t{y}\n";
            }
        }

    }
}
