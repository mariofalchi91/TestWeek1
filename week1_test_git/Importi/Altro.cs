using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_test_git.Importi
{
    public class Altro:ITipo
    {
        public double Calcola(double importo)
        {
            return importo * 0.1;
        }
    }
}
