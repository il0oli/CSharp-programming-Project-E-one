using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class empioyeeBydaty:empioyees
    {
        public empioyeeBydaty(string name, int id)
        {
            Name_emp = name;
            ID = id;
        }
        public virtual void salaryemp()
        {
            int w = int.Parse(Console.ReadLine());
            w = day_work;
            salry = (day_work * 1500);
            Console.WriteLine(salry);
        }
        public virtual void print()
        {
            Console.WriteLine("Name is :" + Name_emp + "\t\tID is:" + ID);
        }
    }
}
