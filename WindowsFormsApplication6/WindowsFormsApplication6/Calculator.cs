using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    class Calculator : InterfaceCalculator
    {
        private double x = 0;
       


        public void Save_X(double x)
        {
            this.x = x;
        }

        public void Clear_X()
        {
            x = 0;
        }

        public double Umnojit (double y)
            {
              return x* y;
            }

        public double Delit (double y)
        {
            return x / y;
        }

        public double Plus(double y)
        {
            return x + y;
        }

        public double Minus(double y)
        {
            return x - y;
        }
    }
}