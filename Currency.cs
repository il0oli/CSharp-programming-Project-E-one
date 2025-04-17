using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Currency
    {
        private double F;
        private double T;

        public double f
        {
            get { return F; }
            set { F = value; }
        }
        public double t
        {
            get { return T; }
            set { T = value; }
        }

        public Currency(double F, double T)
        {
            this.T = T;
            this.F = F;
        }

        public Currency()
        {

        }
    }
}
