using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  abstract  class Cell_Phone
    {
        public string[] Name = new string[100];

        public double[] Price = new double[100];

        public int[] Kg = new int[500];
        public double Sum;
        public int counter = 0;


        public int Q;
        public int Num;



        abstract public void Display();
        abstract public void Print();
    }
}
