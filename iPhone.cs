using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class iPhone:Cell_Phone
    {
        public double[] Price2 = new double[100];
        public string[] Name2 = new string[100];

        public override void Display()
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("     ----   Choose The Phones You Want To Buy And Select The Quantity  -----");
         
            Console.WriteLine("\n\n");
            Console.WriteLine("                                << iPhone >>                ");
            Console.WriteLine("                         -------------------------");
            Console.WriteLine("                       ------------------------------");
            Console.WriteLine("______________________----------------------------------________________________");
            Console.WriteLine("|_____________________/__________________________________\\_____________________|");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|-------------------------------------------------------------------------------|");
            Console.WriteLine("|_______________________________________________________________________________|");
            Console.WriteLine("|---------------------------|--------------|----------------------|-------------|");
            Console.WriteLine("|     Name Cell Phone       |   Price      |   Name Cell Phone    |  Price      |");
            Console.WriteLine("|---------------------------|--------------|----------------------|-------------|");
            Console.WriteLine("|___________________________|______________|______________________|_____________|");
            Console.WriteLine("|                           |              |                      |             |");
            Console.WriteLine("| 1-  iPhone 14 Pro Max     |    1099$     |  2-  iPhone 14 pro   |  999$       |");
            Console.WriteLine("| 3-  iPhone 14 plus        |    899$      |  4-  iphone 14       |  799$       |");
            Console.WriteLine("| 5-  iPhone 13 Pro Max     |    1100$     |  6-  iPhone SE 2022  |  580$       |");
            Console.WriteLine("| 7-  iPhone 13 Pro         |    1000$     |  8-  iPhone 13       |  800$       |");
            Console.WriteLine("| 9-  iPhone 13 Mini        |    1000$     |  10- iPhone 12 Pro   |  900$       |");
            Console.WriteLine("| 11- iPhone 12 Pro Max     |    1300$     |  12- iPhone SE 2020  |  850$       |");
            Console.WriteLine("| 13- iPhone 12 Pro Max     |    1100$     |  14- iPhone 12 Mini  |  600$       |");
            Console.WriteLine("| 15- iPhone 11 Pro Max     |    900$      |  16- iPhone 11 Pro   |  850$       |");
            Console.WriteLine("| 17- iPhone 11             |    450%      |  18- iPhone XS       |  300$       |");
            Console.WriteLine("| 19- iPhone 8              |    350$      |  20- iPhone 7        |  200$       |");
            Console.WriteLine("| 0-  Exit                  |              |                      |             |");
            Console.WriteLine("|---------------------------|--------------|----------------------|-------------|");
            Console.WriteLine("|___________________________|______________|______________________|_____________|");


            Console.WriteLine("\n\nDo You Want To End The Process ?, Enter (0)");  


            Name[0] = "iPhone 14 Pro Max "; Name[1] = "iPhone 14 pro";
            Name[2] = "iPhone 14 plus "; Name[3] = "iphone 14  ";
            Name[4] = "iPhone 13 Pro Max"; Name[5] = "iPhone SE 2022";
            Name[6] = "iPhone 13 Pro"; Name[7] = "iPhone 13";
            Name[8] = "iPhone 13 Mini"; Name[9] = "iPhone 12 Pro";
            Name[10] = "iPhone 12 Pro Max "; Name[11] = " iPhone SE 2020 ";
            Name[12] = "iPhone 12 Pro Max"; Name[13] = "iPhone 12 Mini ";
            Name[14] = "iPhone 11 Pro Max "; Name[15] = "iPhone 11 Pro ";
            Name[16] = "iPhone 11 "; Name[17] = "iPhone XS";
            Name[18] = "iPhone 8 "; Name[19] = "iPhone 7 ";


            Price[0] = 1099; Price[1] = 999; Price[2] = 899;
            Price[3] = 799; Price[4] = 1100; Price[5] = 580;
            Price[6] = 1000; Price[7] = 800; Price[8] = 1000;
            Price[9] = 900; Price[10] = 1300; Price[11] = 850;
            Price[12] = 1100; Price[13] = 600; Price[14] = 900;
            Price[15] = 850; Price[16] = 450; Price[17] = 300;
            Price[18] = 350; Price[19] = 200;

            do
            {
                for (int j = 0; j < 20; j++)
                {
                    Num = 0;
                    Q = 0;

                    Console.Write("Choose  The Phone You Want To Buy  From The Menu : ");
                    Q = int.Parse(Console.ReadLine());
                    if (Q == 0)
                    {
                        break;
                    }
                    if (Q > 0 && Q <= 20)
                    {
                        Console.Write("How Many Phones  Do You Want Of This Type : ");
                        Num = int.Parse(Console.ReadLine());
                    }

                    for (int i = 0; i < 20; i++)
                    {
                        if (i == (Q - 1))
                        {
                            Name2[j] = Name[--Q];
                            Price2[j] = Price[Q];
                            Sum += Num * Price[Q];
                            Kg[j] = Num;

                        }
                    }
                    
                  
                    
                }


            } while (Q != 0);


        }

        public override void Print()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Clear();

            Console.WriteLine("\t\t\t\t\t\t-------- AN ACOUNT BILL -----------");
            Console.WriteLine("\t\t\t\t__________________________________________________________");
            Console.WriteLine("\t\t\t\t|           Name Phone         |  Number   |   Price      |");
            Console.WriteLine("\t\t\t\t|------------------------------|-----------|--------------|");
            for (int j = 0; j < 20; j++)
            {
                for (int i = 0; i < 20; i++)
                {


                    if (Name2[j] == Name[i])
                    {
                        Console.WriteLine("\t\t\t\t|" + ++counter + "- The {0,22:C} |   [{1,2:D}]\t   |{2,15:C}", Name2[j], Kg[j], Kg[j] * Price2[j] + " $    |");
                    }
                }

            }
            Console.WriteLine("\t\t\t\t|______________________________|__________________________|");
            Console.Write("\t\t\t\t| TOTAL CLOUD :  {0,12:C} ", Sum + " $");
            Console.WriteLine("{0,28:D}", "                            |");
            Console.Write("\t\t\t\t| Date :" + DateTime.Now);
            Console.WriteLine("{0,28:D}  ", "                             |");
            Console.WriteLine("\t\t\t\t|_________________________________________________________|");

           
        }
    }
}
