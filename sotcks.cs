using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class sotcks
    {
        public int number;
        public double prodect;
        public string name;
        private double price;
        public string day_e;

        private int p2;
        private int p3;
        private int n31;
        private string name_;
        private int n32;
        private double punch;
        private int day_E;
        private int n;
        private string na;
        private double x;
        private double y;


        public sotcks(int nu, string n, double p, double pp, string day_E)
        {
            this.day_e = day_E;
            this.number = nu;
            this.name = n;
            this.prodect = p;
            this.price = pp;
        }

        public sotcks(int p2, int p3)
        {
            // TODO: Complete member initialization

            this.p2 = p2;
            this.p3 = p3;
        }

        public sotcks(int n31, string name_, int n32, double punch, int day_E)
        {
            // TODO: Complete member initialization
            this.n31 = n31;
            this.name_ = name_;
            this.n32 = n32;
            this.punch = punch;
            this.day_E = day_E;
        }

        public sotcks(int n, string na, double x, double y)
        {
            // TODO: Complete member initialization
            this.n = n;
            this.na = na;
            this.x = x;
            this.y = y;
        }
        /*
       public sotcks(int n31, string name_, int n32, double punch, int day_E)
       {
           // TODO: Complete member initialization
           this.n31 = n31;
           this.name_ = name_;
           this.n32 = n32;
           this.punch = punch;
           this.day_E = day_E;
       }*/
        public virtual void print()
        {
            Console.WriteLine(number + "\t" + name + "\t" + prodect + "\t" + price + "\t" + day_e);

        }
        public double pricce
        {
            set { value = price; }
            get { return price; }
        }
          
    }
}
