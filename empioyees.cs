using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class empioyees
    {
        public string Name_emp;
        public double salry;
        public int ID;
        public int day_work = 0;

        //        public abstract empioyees();



        public virtual void print()
        {
            Console.WriteLine();
        }



        public virtual void salaryemp()
        {
            Console.WriteLine();
        }
    }
}
