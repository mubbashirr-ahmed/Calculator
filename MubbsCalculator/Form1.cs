using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MubbsCalculator
{
    public partial class Mubbashir : Form
    {
        public string numm = "";
        public Mubbashir()
        {
            InitializeComponent();
            point.Font = new Font(point.Font.FontFamily, 16);
            equation.Font = new Font(equation.Font.FontFamily, 16);
            answer.Font = new Font(answer.Font.FontFamily, 14);
        }
        private void one_Click(object sender, EventArgs e)
        {
            numm += "1";
            equation.Text = numm;
        }
        private void two_Click(object sender, EventArgs e)
        {
            numm += "2";
            equation.Text = numm;
        }

        private void three_Click(object sender, EventArgs e)
        {
            numm += "3";
            equation.Text = numm;
        }

        private void four_Click(object sender, EventArgs e)
        {
            numm += "4";
            equation.Text = numm;
        }

        private void five_Click(object sender, EventArgs e)
        {
            numm += "5";
            equation.Text = numm;
        }

        private void six_Click(object sender, EventArgs e)
        {
            numm += "6";
            equation.Text = numm;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            numm += "7";
            equation.Text = numm;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            numm += "8";
            equation.Text = numm;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            numm += "9";
            equation.Text = numm;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            numm += "0";
            equation.Text = numm;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            numm += "+";
            equation.Text = numm;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            numm += "-";
            equation.Text = numm;
        }
        private void product_Click(object sender, EventArgs e)
        {
            
            numm += "x";
            equation.Text = numm;
        }
        private void divide_Click(object sender, EventArgs e)
        {
            numm += "/";
            equation.Text = numm;
        }
        private void power_Click(object sender, EventArgs e)
        {
            numm += "^";
            equation.Text = numm;
        }
        private void root_Click(object sender, EventArgs e)
        {
            numm += "√";
            equation.Text = numm;
        }
        private void sin_Click(object sender, EventArgs e)
        {
            numm += "s";
            equation.Text = numm;
        }
        private void cos_Click(object sender, EventArgs e)
        {
            numm += "c";
            equation.Text = numm;
        }
        private void tan_Click(object sender, EventArgs e)
        {
            numm += "t";
            equation.Text = numm;
        }
        private void equal_Click(object sender, EventArgs e)
        {
            Calculation c = new Calculation(numm);
            string final_result = c.solution();
            answer.Text = "=" + final_result;
            numm = final_result;
        }
        private void point_Click(object sender, EventArgs e)
        {
            numm += ".";
            equation.Text = numm;
        }
        private void log_Click(object sender, EventArgs e)
        {
            numm += "l";
            equation.Text = numm;
        }
        private void mod_Click(object sender, EventArgs e)
        {
            numm += "%";
            equation.Text = numm;
        }
        private void clear_Click(object sender, EventArgs e)
        {
            numm = "";
            equation.Text =  "0";
            answer.Text = "0";
        }
        private void factorial_Click(object sender, EventArgs e)
        {
            numm += "!";
            equation.Text = numm;
        }
    }
}
