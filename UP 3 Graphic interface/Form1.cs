using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_3_Graphic_interface
{
    public partial class Form1 : Form
    {
        static double Function(double x) => x * x * x - Math.Sin(x);
        public Form1()
        {
            InitializeComponent();
        }

        private void GetTableButton_Click(object sender, EventArgs e)
        {
            AnswerBox.Text = "";
            if (!double.TryParse(AValueBox.Text, out double a))
            {
                AnswerBox.Text = "В поле значения а введены недопустимые данные!";
                return;
            }

            if (!double.TryParse(BValueBox.Text, out double b))
            {
                AnswerBox.Text = "В поле значения b введены недопустимые данные!";
                return;
            }

            double f_a = Function(a);
            double f_b = Function(b);

            AnswerBox.Text += $"В точке а ({a}) значение функции равно {f_a}\n";

            AnswerBox.Text += $"В точке b ({b}) значение функции равно {f_b}\n";

            AnswerBox.Text += (f_a > f_b) ? "Значение фунции в точке а больше чем в точке b" : (f_a < f_b) ?
                "Значение фунции в точке b больше чем в точке a" : "Значение фунции в точке b и в точке a равны"; 
        }
    }
}
