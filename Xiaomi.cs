using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Xiaomi:Cell_Phone
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
            Console.WriteLine("\n\n");
            Console.WriteLine("                                               << Xiaomi >>               ");
            Console.WriteLine("                                       -------------------------");
            Console.WriteLine("                                     ------------------------------");
            Console.WriteLine("___________________________________----------------------------------______________________________________");
            Console.WriteLine("|_________________________________/__________________________________\\____________________________________|");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|__________________________________________________________________________________________________________|");
            Console.WriteLine("|----------------------------------------|--------------|------------------------------------|-------------|");
            Console.WriteLine("|           Name Cell Phone              |   Price      |          Name Cell Phone           |  Price      |");
            Console.WriteLine("|----------------------------------------|--------------|------------------------------------|-------------|");
            Console.WriteLine("|________________________________________|______________|____________________________________|_____________|");
            Console.WriteLine("|                                        |              |                                    |             |");
            Console.WriteLine("|   1-  Xiaomi 12T Pro                   |     715  $   |    11- Xioami Poco F4 GT           |    605  $   |");
            Console.WriteLine("|   2-  Xiaomi Watch s1 Pro              |     220  $   |    12- Xioami Black Shark 5        |    540  $   |");
            Console.WriteLine("|   3-  Xiaomi 12T                       |     550  $   |    13- Xioami Black Shark 5 Pro    |    650  $   |");
            Console.WriteLine("|   4-  Xiaomi Mix Fold 2                |     1300 $   |    14- Xioami Civi 1S              |    350  $   |");
            Console.WriteLine("|   5-  Xiaomi Mi 11 Ultra               |     1300 $   |    15- Xioami 12S Pro              |    670  $   |");
            Console.WriteLine("|   6-  Xiaomi Mi Mix Fold               |     1500 $   |    16- Xioami  12 Lite             |    445  $   |");
            Console.WriteLine("|   7-  Xiaomi Civi 2                    |     350  $   |    17- Xioami  12S Ultra           |    955  $   |");
            Console.WriteLine("|   8-  Xiaomi poco M4 Pro               |     240  $   |    18- Xioami Redmi 10 Prime 2022  |    167  $   |");
            Console.WriteLine("|   9-  Xioami Redmi K50i                |     325  $   |    19- Xioami Redmi Note 11SE      |    160  $   |");
            Console.WriteLine("|   10- Xioami Redmi K50 Ultra           |     625  $   |    20- Xioami Redmi 10X Pro 5G     |    300  $   |");
            Console.WriteLine("|   0-  Exit  t                          |              |                                    |             |");
            Console.WriteLine("|----------------------------------------|--------------|------------------------------------|-------------|");
            Console.WriteLine("|________________________________________|______________|____________________________________|_____________|");


            Console.WriteLine("\n\nDo You Want To End The Process ?, Enter (0)");

            Name[0] = " Xiaomi 12T Pro  "; Name[1] = "Xiaomi Watch s1 Pro  ";
            Name[2] = "Xiaomi 12T "; Name[3] = "Xiaomi Mix Fold 2  ";
            Name[4] = " Xiaomi Mi 11 Ultra"; Name[5] = "Xiaomi Mi Mix Fold ";
            Name[6] = "Xiaomi Civi 2  "; Name[7] = "Xiaomi poco M4 Pro";
            Name[8] = "Xioami Redmi K50i"; Name[9] = "Xioami Redmi K50 Ultra";
            Name[10] = "Xioami Poco F4 GT"; Name[11] = " Xioami Black Shark 5";
            Name[12] = "Xioami Black Shark 5 Pro"; Name[13] = " Xioami Civi 1S ";
            Name[14] = "Xioami 12S Pro "; Name[15] = "Xioami  12 Lite";
            Name[16] = "Xioami  12S Ultra"; Name[17] = "Xioami Redmi 10 Prime 2022";
            Name[18] = "Xioami Redmi Note 11SE "; Name[19] = " Xioami Redmi 10X Pro 5G  ";



            Price[0] = 715; Price[1] = 220; Price[2] = 550;
            Price[3] = 1300; Price[4] = 1300; Price[5] = 1500;
            Price[6] = 350; Price[7] = 240; Price[8] = 325;
            Price[9] = 625; Price[10] = 605; Price[11] = 540;
            Price[12] = 650; Price[13] = 350; Price[14] = 670;
            Price[15] = 445; Price[16] = 955; Price[17] = 167;
            Price[18] = 160; Price[19] = 300;





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
            Console.WriteLine("\t\t\t\t|______________________________________|__________________________|");
            Console.Write("\t\t\t\t| TOTAL CLOUD :  {0,12:C} ", Sum + " $");
            Console.WriteLine("{0,37:D}", "                              |");
            Console.Write("\t\t\t\t| Date :" + DateTime.Now);
            Console.WriteLine("{0,28:D}  ", "                                     |");
            Console.WriteLine("\t\t\t\t|_________________________________________________________________|");

           
        }
    }
}
