using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Motorola:Cell_Phone
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
            Console.WriteLine("                                            << Motorola >>               ");
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
            Console.WriteLine("|   1-  Motorola Edge (2022)             |     290  $   |    11- Motorola Moto G Power(2022) |    200  $   |");
            Console.WriteLine("|   2-  Motorola Edge 30 Note            |     370  $   |    12- Motorola Moto Tab G70       |    390  $   |");
            Console.WriteLine("|   3-  Motorola Moto Razr (2022)        |     860  $   |    13- Motorola Edge S30           |    310  $   |");
            Console.WriteLine("|   4-  Motorola Moto G72                |     280  $   |    14- Motorola Moto E30           |    165  $   |");
            Console.WriteLine("|   5-  Motorola Edge 30 Ultra           |     957  $   |    15- Motorola Edge 30 pro        |    1000 $   |");
            Console.WriteLine("|   6-  Motorola Edge 30 Fusion          |     600  $   |    16- Motorola Edge 20 Pro        |    577  $   |");
            Console.WriteLine("|   7-  Motorola Moto G22                |     155  $   |    17- Motorola Edge 20 lite       |    360  $   |");
            Console.WriteLine("|   8-  Motorola Moto X30 Pro            |     555  $   |    18- Motorola Moto G41           |    430  $   |");
            Console.WriteLine("|   9-  Motorola Moto G Styus 5G (2022)  |     500  $   |    19- Motorola Moto G71 5G        |    465  $   |");
            Console.WriteLine("|   10- Motorola Edge X30                |     465  $   |    20- Motorola Moto G Stylus      |    300  $   |");
            Console.WriteLine("|   0-  Exit  t                          |              |                                    |             |");
            Console.WriteLine("|----------------------------------------|--------------|------------------------------------|-------------|");
            Console.WriteLine("|________________________________________|______________|____________________________________|_____________|");


            Console.WriteLine("\n\nDo You Want To End The Process ?, Enter (0)");

            Name[0] = " Motorola Edge (2022) "; Name[1] = "Motorola Edge 30 Note ";
            Name[2] = "Motorola Moto Razr (2022) "; Name[3] = "Motorola Moto G72  ";
            Name[4] = " Motorola Edge 30 Ultra"; Name[5] = "Motorola Edge 30 Fusion  ";
            Name[6] = "Motorola Moto G22"; Name[7] = "Motorola Moto X30 Pro ";
            Name[8] = "Motorola Moto G Styus 5G (2022)"; Name[9] = "Motorola Edge X30 ";
            Name[10] = "Motorola Moto G Power(2022)"; Name[11] = " Motorola Moto Tab G70 ";
            Name[12] = "Motorola Edge S30 "; Name[13] = " Motorola Moto E30  ";
            Name[14] = "Motorola Edge 30 pro"; Name[15] = "Motorola Edge 20 Pro";
            Name[16] = "Motorola Edge 20 lite "; Name[17] = "Motorola Moto G41";
            Name[18] = "Motorola Moto G71 5G  "; Name[19] = " Motorola Moto G Stylus ";



            Price[0] = 290; Price[1] = 370; Price[2] = 860;
            Price[3] = 280; Price[4] = 957; Price[5] = 600;
            Price[6] = 155; Price[7] = 555; Price[8] = 500;
            Price[9] = 465; Price[10] = 200; Price[11] = 390;
            Price[12] = 310; Price[13] = 165; Price[14] = 1000;
            Price[15] = 577; Price[16] = 360; Price[17] = 430;
            Price[18] = 465; Price[19] = 300;





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
