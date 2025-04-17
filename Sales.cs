using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Sales
    {
        public int Cont = 0;

        public int unmber_;
        public int punch;

        public void inpot(int p)
        {
            punch = p;
        }
        public void Sale(int p)
        {
            unmber_ = p;

        }





        public Sales()
        {
            // TODO: Complete member initialization
        }
        public double sum_punch(double x, double z)
        {
            return x * z;
        }
        public void print()
        {
            Console.Write(punch + "\t");
        }

    }
}
