using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MubbsCalculator
{
    internal class Operator
    {
        public bool op(char c)
        {
            if(c == '+' || c == '-' || c=='x' || c=='/' || c=='%' || c =='l' || c=='c' || c == 't' || c == 's' || c == '^' || c == '!' || c == '√')
            {
                return true;
            }
            else 
                return false;
        }
    }
}
