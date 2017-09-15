using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    interface InterfaceCalculator
    {
        void Save_X(double x);
        void Clear_X();
        double Umnojit(double y);
        double Delit(double y);
        double Plus(double y);
        double Minus(double y);

      /*  void M_Umnojit(double y);
        void M_Delit(double y);
        void M_Plus(double y);
        void M_Minus(double y);
        */

    }
}
