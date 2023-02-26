using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MubbsCalculator
{
    internal class Calculation
    {
        private string equation;
        private double sol;
        private int i;
        private char op;
        private string str1;
        private string str2;
        private int len;
        public Calculation(string res)
        {
            equation = res;
            i = 0;
            op = 'm';
            str1 = "";
            str2 = "";
            len = equation.Length;
        }
        public string solution()
        { 
            if (equation=="")
            {
                return "";
            }
            else
            {
                check_operator();
                try
                {
                    return Convert.ToString(get_result());
                }
                catch (Exception)
                {
                    return "Invalid Syntax";
                }
            }
        }
        private void check_operator()
        {
            Operator o = new Operator();
            while (i < len)
            {
                if(o.op(equation[i]))
                {
                    op = equation[i];
                    break;
                }
                else
                {
                    str1 += equation[i];
                    i++;
                }
            }
            i++;
            while (i < len)
            {
                
                if(o.op(equation[i]))
                {
                    str1 = Convert.ToString(get_result());
                    check_operator();
                }
                else
                {
                    str2 += equation[i];
                    i++;
                }
            }
        }
        private double get_result()
        {
            double num1, num2;
            if(str1 == "")
            {
                num2 = Convert.ToDouble(str2);
                if (op == '√')
                {
                    sol = Math.Sqrt(num2);
                }
                else if (op == 's')
                {
                    sol = Math.Sin(num2);
                }
                else if (op == 'c')
                {
                    sol = Math.Cos(num2);
                }
                else if (op == 't')
                {
                    sol = Math.Tan(num2);
                }
                else if (op == 'l')
                {
                    sol = Math.Log(num2);
                }
            }
            else if(str2 == "")
            {
                num1 = Convert.ToDouble(str1);
                if(op == '!')
                {
                    double fact = 1;
                    for(double i = 1; i<=num1; i++)
                    {
                        fact *= i;
                    }
                    sol = fact;
                }
            }
            else
            {
                num1 = Convert.ToDouble(str1);
                num2 = Convert.ToDouble(str2);
                if (op == '-')
                {
                    sol = num1 - num2;
                }
                else if (op == '+')
                {
                    sol = num1 + num2;
                }
                else if (op == 'x')
                {
                    sol = num1 * num2;
                }
                else if (op == '/')
                {
                    sol = num1 / num2;
                }
                else if (op == '%')
                {
                    sol = num1 - num2;
                }
                else if (op == '^')
                {
                    sol = Math.Pow(num1, num2);
                }
            }
            str1 = "";
            str2 = "";
            return sol;
        }
    }
}
