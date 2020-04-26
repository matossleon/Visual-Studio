using System;
using System.Collections.Generic;
using System.Text;

namespace Cotação_Dólar
{
    class ConversordeMoeda
    {
        static public double Cot, Qnt;
        static public double Conversao()
        {
            return Qnt * Cot * (1 + Iof / 100);
        }
        static public double Iof = 6.00;
    }
}
