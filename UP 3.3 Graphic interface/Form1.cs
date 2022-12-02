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
            double a, b, h;
            AnswerBox.Text = "";

            if (!double.TryParse(AValueBox.Text, out a))
            {
                AnswerBox.Text = "В поле а введены недопустимые значения!";
                return;
            }

            if (!double.TryParse(BValueBox.Text, out b))
            {
                AnswerBox.Text = "В поле b введены недопустимые значения!";
                return;
            }

            if (!double.TryParse(HValueBox.Text, out h))
            {
                AnswerBox.Text = "В поле h введены недопустимые значения!";
                return;
            }

            AnswerBox.Text += "Таблица значений\n";
            AnswerBox.Text += "x\t|\ty\n"; AnswerBox.Text += "===============\n";
            var count = (int)(Math.Ceiling(b - a) / h + 1);
            for (int i = 0; i < count; i++)
            {
                var x = a + i * h;
                double y;
                Function(x, a, out y);
                AnswerBox.Text += $"{x}\t|\t{y}\n";
            }
        }

    }
}
