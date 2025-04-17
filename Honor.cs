using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Honor:Cell_Phone
    {
        public double[] Price2 = new double[100];
        public string[] Name2 = new string[100];

        public override void Display()
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
          
            Console.WriteLine("\n\n");
            Console.WriteLine("        -------   Choose The Phones You Want To Buy And Select The Quantity    ------------");
            Console.WriteLine("\n");
            Console.WriteLine("                                                Honor                ");
            Console.WriteLine("                                       -------------------------");
            Console.WriteLine("                                     ------------------------------");
            Console.WriteLine("___________________________________----------------------------------______________________________________");
            Console.WriteLine("|_________________________________/__________________________________\\____________________________________|");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|        --------------   Choose The Phones You Want To Buy And Select The Quantity    --------------------|");
            Console.WriteLine("|__________________________________________________________________________________________________________|");
            Console.WriteLine("|----------------------------------------|--------------|------------------------------------|-------------|");
            Console.WriteLine("|           Name Cell Phone              |   Price      |          Name Cell Phone           |  Price      |");
            Console.WriteLine("|----------------------------------------|--------------|------------------------------------|-------------|");
            Console.WriteLine("|________________________________________|______________|____________________________________|_____________|");
            Console.WriteLine("|                                        |              |                                    |             |");
            Console.WriteLine("|   1-  Honor Magic 4                    |     900  $   |    11- Honor Magic4 Ultimate       |    1170 $   |");
            Console.WriteLine("|   2-  Honor Play6C                     |     160  $   |    12- Honor Magic4 lite           |    435  $   |");
            Console.WriteLine("|   3-  Honor X40 TG                     |     300  $   |    13- Honor X8 5G                 |    215  $   |");
            Console.WriteLine("|   4-  Honor X40                        |     210  $   |    14- Honor X40i                  |    245  $   |");
            Console.WriteLine("|   5-  Honor Phay6T Pro                 |     215  $   |    15- Honor Magic V               |    1600 $   |");
            Console.WriteLine("|   6-  Honor Pad 8                      |     215  $   |    16- Honor X30                   |    235  $   |");
            Console.WriteLine("|   7-  Honor Magic4 Pro                 |     1220 $   |    17- Honor 60                    |    460  $   |");
            Console.WriteLine("|   8-  Honor 70                         |     400  $   |    18- Honor 60 Pro                |    580  $   |");
            Console.WriteLine("|   9-  Honor 70 Pro                     |     540  $   |    19- Honor Magic3 Pro Plus       |    1190 $   |");
            Console.WriteLine("|   10- Honor X8                         |     300  $   |    20- Honor Magic3                |    750  $   |");
            Console.WriteLine("|   0-  Exit  t                          |              |                                    |             |");
            Console.WriteLine("|----------------------------------------|--------------|------------------------------------|-------------|");
            Console.WriteLine("|________________________________________|______________|____________________________________|_____________|");

            Console.WriteLine("\n\nDo You Want To End The Process ?, Enter (0)");
            Name[0] = " Honor Magic 4 "; Name[1] = "Honor Play6C  ";
            Name[2] = "Honor X40 TG  "; Name[3] = "Honor X40  ";
            Name[4] = " Honor Phay6T Pro "; Name[5] = "Honor Pad 8  ";
            Name[6] = "Honor Magic4 Pro "; Name[7] = "Honor 70  ";
            Name[8] = "Honor 70 Pro"; Name[9] = "Honor X8 ";
            Name[10] = "Honor Magic4 Ultimate "; Name[11] = " Honor Magic4 lite ";
            Name[12] = "Honor X8 5G"; Name[13] = " Honor X40i";
            Name[14] = "Honor Magic V "; Name[15] = " Honor X30 ";
            Name[16] = "Honor 60 "; Name[17] = "Honor 60 Pro ";
            Name[18] = "Honor Magic3 Pro Plus"; Name[19] = " Honor Magic3 ";

            Price[0] = 900; Price[1] = 160; Price[2] = 300;
            Price[3] = 210; Price[4] = 215; Price[5] = 215;
            Price[6] = 1220; Price[7] = 400; Price[8] = 540;
            Price[9] = 300; Price[10] = 1170; Price[11] = 435;
            Price[12] = 215; Price[13] = 245; Price[14] = 1600;
            Price[15] = 235; Price[16] = 460; Price[17] = 580;
            Price[18] = 1190; Price[19] = 750;





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
                    if (Q > 0 && Q <= 36)
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
            Console.WriteLine("\t\t\t\t__________________________________________________________________");
            Console.WriteLine("\t\t\t\t|               Name Phone             |  Number   |   Price      |");
            Console.WriteLine("\t\t\t\t|--------------------------------------|-----------|--------------|");
            for (int j = 0; j < 20; j++)
            {
                for (int i = 0; i < 20; i++)
                {


                    if (Name2[j] == Name[i])
                    {
                        Console.WriteLine("\t\t\t\t|" + ++counter + "- The {0,30:C} |   [{1,2:D}]\t   |{2,15:C}", Name2[j], Kg[j], Kg[j] * Price2[j] + " $    |");
                    }
                }

            }
            Console.WriteLine("\t\t\t\t|______________________________________|___________|______________|");
            Console.Write("\t\t\t\t| TOTAL CLOUD :  {0,12:C} ", Sum + " $");
            Console.WriteLine("{0,37:D}", "                              |");
            Console.Write("\t\t\t\t| Date :" + DateTime.Now);
            Console.WriteLine("{0,28:D}  ", "                                     |");
            Console.WriteLine("\t\t\t\t|_________________________________________________________________|");

        }
    }
}
