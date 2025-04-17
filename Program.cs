using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int x;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            again:
            Console.Clear();
                     
            do
            {
                Console.WriteLine("\n\n\t\t\t\t\t\t __________WELCOME_________");
                Console.WriteLine(" \t\t\t\t\t|---------------------------------------------|");
                Console.WriteLine("\t\t\t\t\t|" + CenterEone.Center);
                Console.WriteLine("\t\t\t\t\t|_____________________________________________|");
                Console.WriteLine("\t\t\t\t\t|                                             |");
                Console.WriteLine("\t\t\t\t\t|_________________Main Menu___________________|");
                Console.WriteLine("\t\t\t\t\t| Select The Section You Want To Go To :      |");
                Console.WriteLine("\t\t\t\t\t|_____________________________________________|\n\n");
                Console.WriteLine("\t\t\t\t ______________________________________________________________");
                Console.WriteLine("\t\t\t\t|--------------------------------------------------------------|");
                Console.WriteLine("\t\t\t\t|______________________________________________________________|");
                Console.WriteLine("\t\t\t\t|1- Gold Department           2- Currency Conversion Department|");
                Console.WriteLine("\t\t\t\t|3- Subermarket Department    4- Resturant Department          |");
                Console.WriteLine("\t\t\t\t|5- Electronics Department    0- Exit                          |");
                Console.WriteLine("\t\t\t\t|--------------------------------------------------------------|");
                Console.WriteLine("\t\t\t\t|______________________________________________________________|\n");

                Console.Write("\t\t\t\t Choose From Here : ");
                x = int.Parse(Console.ReadLine());
                if(x==1)
                {
                    Console.Clear();
                    Gold g = new Gold();
                    g.print();
                }

                else if (x == 2)
                {
                    Console.Clear();
                    CurrencyConversion c = new CurrencyConversion();
                    c.printCurr();
                }

                else if(x==3)
                {
                    Console.Clear();
                       int z=0;

                       Console.WriteLine("\t\t\t\t|__________________________________________________|");
                       Console.WriteLine("\t\t\t\t|                                                  |");
                       Console.WriteLine("\t\t\t\t|  1- Stors                2- print Stors          |");
                       Console.WriteLine("\t\t\t\t|  3- Add category         4- Print Category       |");
                       Console.WriteLine("\t\t\t\t|  5- Add Employee         6- print Employee       |");
                       Console.WriteLine("\t\t\t\t|  7- Salary Employee      8- Input sels           |");
                       Console.WriteLine("\t\t\t\t|  9- Print sels           0 - Exit                |");
                       Console.WriteLine("\t\t\t\t|--------------------------------------------------|");
                       Console.WriteLine("\t\t\t\t|__________________________________________________|");
            double[] sum = new double[100];
            empioyees[] emp = new empioyeeBydaty[5];
                Sales[] s = new Sales[100];
                sotcks[] xe = new sotcks[100];
                Console.WriteLine("Do not enter category ,enter the number one");//   1 الادخال
                Console.WriteLine("To print items");
                Console.WriteLine("To add quantity to sotck");
                Console.WriteLine("To print after adding");
            
            z = int.Parse(Console.ReadLine());   
           
            
            if (z == 1)
                {
                    for (int i = 0; i < 2; )
                    {
                        Console.WriteLine("enter the number prodect");
                        int n3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the your name ");
                        string name_ = Console.ReadLine();
                        Console.WriteLine("Enter the is prodect");
                        double punch_ = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the prics");
                        double punch = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the day is expira date");
                        string day_E = (Console.ReadLine());
                        if ((punch > 0) && (punch_ > 0))
                        {
                            xe[i] = new sotcks(n3, name_, punch_, punch, day_E);
                            i++;
                        }
                        else
                            Console.WriteLine("These naluse cannot be entered");
                    }
                }
           
             if(z==2)
            {



                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine(  "number \t Name \t prodect \t price dad_e");
            for (int i = 0; i < 2; i++)
                {
                    xe[i].print();
                }
            }
            if(z==3)
            {

                
                Console.WriteLine("__________________________________________________________________");
                for(int i=0;i<2;i++)
                {
                    Console.WriteLine("enter the number punch");
                int a =int.Parse(Console.ReadLine());
                if (xe[i].number == a)
                {
                    int ww = int.Parse(Console.ReadLine());
                    xe[i].prodect += ww;
                }
                else
                    Console.WriteLine("punch is not existing enter the number punch agen");
                }

            }
            if(z==4)
            {


                Console.WriteLine(  "____________________________________________________________");
                for (int i = 0; i < 2; i++)//print after
                {
                    xe[i].print();
                }
                
                
            }
             if(z==5)
            {
                    Console.WriteLine("_________________________________________________");
                  
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Enter the your name Empioyee ");
                        string named = Console.ReadLine();
                        Console.WriteLine("enter the ID Empioyee");
                        int ID = int.Parse(Console.ReadLine());
                        emp[i] = new empioyeeBydaty (named,ID);
                        
                    }
            }
             if(z==6)
            {
                    for (int k = 0; k < 5; k++)
                    {
                        emp[k].print();
                    }
            }
            if(z==7)
            {
                    for (int t = 0; t < emp.Length; t++)
                    {
                        Console.WriteLine("empioyeee salary is ");
                        int b=int.Parse( Console.ReadLine());
                        emp[t].salaryemp();
                    }
                
            }


                Console.WriteLine("____________________________________________________");
                
             if(z==8)
            {
                //      Console.WriteLine("Enter the prodeuct number");
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Enter the prodeuct number");
                    int ee = int.Parse(Console.ReadLine());
                    s[i] = new Sales();
                    s[i].Sale(ee);

                     //if (s[i].unmber_== 0)
                     //break; 
                        if (xe[i].number == s[i].unmber_) 
                       //{
                    Console.WriteLine("Enter the quantity");
                    int rr = int.Parse(Console.ReadLine());
                    s[i].inpot(rr);
                    sum[i] = (xe[ee].pricce * s[i].punch);
                    xe[i].prodect -= s[i].punch;
                    Console.WriteLine("\n\n\n");
                 //   x[i].print();
                   // Console.WriteLine(sum[i]);
                     //}
                     //else
                     // Console.WriteLine("The montage you entered does not prodeuct number");

                }
            }
            if(z==9)
            {
                double totitl = 0;
                for (int j = 0; j < 1; j++)
                {
                    for (int l = 0; l < sum.Length; l++)
                    {
                         s[l].print();
                        Console.WriteLine(xe[s[l].unmber_].pricce + "\t" + sum[l]);
                        totitl = +sum[l];
                    }
                    Console.WriteLine(totitl);
                    Console.WriteLine("| Date :" + DateTime.Now);
                    z = int.Parse(Console.ReadLine());
                    if (z == 0)
                    {
                        break;
                    }
            
                }
                
            }
              
    
            
            
                }
                else if (x == 4)
                {
                    Console.Clear();
                    Resturant R = new Resturant();
                    R.Showing();
                    R.Print();
                }


                else if (x == 5)
                {
                    Console.Clear();
                    int p;
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\t\t\t                  {<< Cell Phones >>}               ");
                    Console.WriteLine("\t\t\t\t            ------------------------------");
                    Console.WriteLine("\t\t\t\t           --------------------------------");
                    Console.WriteLine("\t\t\t\t_________ ----------------------------------________");
                    Console.WriteLine("\t\t\t\t|_______/__________________________________\\_______|");
                    Console.WriteLine("\t\t\t\t|--------------------------------------------------|");
                    Console.WriteLine("\t\t\t\t|--------------------------------------------------|");
                    Console.WriteLine("\t\t\t\t|__________________________________________________|");
                    Console.WriteLine("\t\t\t\t|                                                  |");
                    Console.WriteLine("\t\t\t\t|  1- iPhone                      2- Sumsung       |");
                    Console.WriteLine("\t\t\t\t|  3- Huawei                      4- Xiaomi        |");
                    Console.WriteLine("\t\t\t\t|  5- Motorola                    6- Honor         |");
                    Console.WriteLine("\t\t\t\t|  0- Exit                                         |");
                    Console.WriteLine("\t\t\t\t|--------------------------------------------------|");
                    Console.WriteLine("\t\t\t\t|__________________________________________________|");
                    Console.Write("\t\t\t\t  Choose The Type Of Phone You Want : ");
                    p = int.Parse(Console.ReadLine());

                    if (p == 1)
                    {
                        Cell_Phone i = new iPhone();
                        i.Display();
                        i.Print();
                    }


                    else if (p == 2)
                    {
                        Cell_Phone S = new Samsung();
                        S.Display();
                        S.Print();
                    
                    }

                    else if (p == 3)
                    {
                        Cell_Phone H = new Huawei();
                        H.Display();
                        H.Print();
                    }

                    else if (p==4)
                    {
                        Cell_Phone X = new Xiaomi();
                        X.Display();
                        X.Print();
                    }

                    else if (p == 5)
                    {
                        Cell_Phone M = new Motorola();
                        M.Display();
                        M.Print();
                    }

                    else if (p == 6)
                    {
                        Cell_Phone Ho = new Honor();
                        Ho.Display();
                        Ho.Print();
                    }

                    else {
                        Console.WriteLine("You Selection Errors ");
                    
                    }   
                }

                int Z;
            R : 
                Console.WriteLine();
                Console.WriteLine("\n\n\n 1- ENTER ONE TO RETURN TO THE MAIN MENU    2- ENTER TWO TO FINSH THE PROGRAM :");
                Z= int.Parse(Console.ReadLine());
                switch (Z)
                { 
                    case 1 :
                        goto again;
                        break;

                    case 2 :
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("You Selection Errors Try Again ");
                        goto R;
                        break;
                }




            } while (x != 0);
          
            Console.ReadKey();
        }
    }
}
