using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Huawei:Cell_Phone
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
            Console.WriteLine("                                               << Huawei >>               ");
            Console.WriteLine("                                       -------------------------");
            Console.WriteLine("                                     ------------------------------");
            Console.WriteLine("___________________________________----------------------------------______________________________________");
            Console.WriteLine("|_________________________________/__________________________________\\____________________________________|");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("___________________________________________________________________________________________________________");
            Console.WriteLine("|----------------------------------------|--------------|------------------------------------|-------------|");
            Console.WriteLine("|           Name Cell Phone              |   Price      |          Name Cell Phone           |  Price      |");
            Console.WriteLine("|----------------------------------------|--------------|------------------------------------|-------------|");
            Console.WriteLine("|________________________________________|______________|____________________________________|_____________|");
            Console.WriteLine("|                                        |              |                                    |             |");
            Console.WriteLine("|   1-  Huawei Nova 10 ES                |     400  $   |    21- Huawei MetaPad T8           |    130  $   |");
            Console.WriteLine("|   2-  Huawei Nova 10                   |     500  $   |    22- Huawei MetaPad 10.8         |    600  $   |");
            Console.WriteLine("|   3-  Huawei Meta 40 Pro 4G            |     800  $   |    23- Huawei MetaPad T 10s        |    225  $   |");
            Console.WriteLine("|   4-  Huawei Meta 40                   |     630  $   |    24- Huawei MetaPad X2           |    2750 $   |");
            Console.WriteLine("|   5-  Huawei Meta 40E 4G               |     550  $   |    25- Huawei MetaPad 10 lite      |    300  $   |");
            Console.WriteLine("|   6-  Huawei Meta 40 Pro Plus          |     1400 $   |    26- Huawei Y7 Prime 2019        |    240  $   |");
            Console.WriteLine("|   7-  Huawei Meta 50E                  |     580  $   |    27- Huawei Y6 Prime 2019        |    200  $   |");
            Console.WriteLine("|   8-  Huawei Meta 50                   |     720  $   |    28- Huawei Y7a                  |    185  $   |");
            Console.WriteLine("|   9-  Huawei Nova 10 pro               |     790  $   |    29- Huawei Nova 7i              |    260  $   |");
            Console.WriteLine("|   10- Huawei Meta 50 Pro               |     990  $   |    30- Huawei P Smart 2021         |    230  $   |");
            Console.WriteLine("|   11- Huawei Metapad Pro 11 (2022)     |     515  $   |    31- Huawei Enjoy 20 SE          |    190  $   |");
            Console.WriteLine("|   12- Huawei Nova 9 SE                 |     350  $   |    32- Huawei Meta 30 Pro 5G       |    1750 $   |");
            Console.WriteLine("|   13- Huawei Nova Y90                  |     237  $   |    33- Huawei P5 Pro               |    1150 $   |");
            Console.WriteLine("|   14- Huawei Nova 9 SE 5G              |     390  $   |    34- Huawei Meta 40 Pro          |    1900 $   |");
            Console.WriteLine("|   15- Huawei Nova Y70                  |     215  $   |    35- Huawei P40 Pro              |    1000 $   |");
            Console.WriteLine("|   16- Huawei Nova 8 ES 4G              |     330  $   |    36- Huawei P40 Pro Plus         |    1200 $   |");
            Console.WriteLine("|   17- Huawei Nova 8i                   |     310  $   |                                    |             |");
            Console.WriteLine("|   18- Huawei Watch TG 3                |     225  $   |                                    |             |");
            Console.WriteLine("|   19- Huawei Watch Fit Mini            |     110  $   |                                    |             |");
            Console.WriteLine("|   20- Huawei Watch TG 2 Pro            |     250  $   |                                    |             |");
            Console.WriteLine("|   0-  Exit  t                          |              |                                    |             |");
            Console.WriteLine("|----------------------------------------|--------------|------------------------------------|-------------|");
            Console.WriteLine("|________________________________________|______________|____________________________________|_____________|");


            Console.WriteLine("\n\nDo You Want To End The Process ?, Enter (0)");

            Name[0] = "Huawei Nova 10 ES  "; Name[1] = " Huawei Nova 10  ";
            Name[2] = "Huawei Meta 40 Pro 4G "; Name[3] = " Huawei Meta 40 ";
            Name[4] = " Huawei Meta 40E 4G"; Name[5] = "Huawei Meta 40 Pro Plus ";
            Name[6] = "Huawei Meta 50E "; Name[7] = "Huawei Meta 50";
            Name[8] = "Huawei Nova 10 pro "; Name[9] = "Huawei Meta 50 Pro";
            Name[10] = "Huawei Metapad Pro 11 (2022)"; Name[11] = " Huawei Nova 9 SE";
            Name[12] = "Huawei Nova Y90"; Name[13] = " Huawei Nova 9 SE 5G  ";
            Name[14] = "Huawei Nova Y70 "; Name[15] = "Huawei Nova 8 ES 4G ";
            Name[16] = "Huawei Nova 8i "; Name[17] = "Huawei Watch TG 3 ";
            Name[18] = "Huawei Watch Fit Mini "; Name[19] = "Huawei Watch TG 2 Pro ";


            Name[20] = " Huawei MetaPad T8 "; Name[21] = " Huawei MetaPad 10.8";
            Name[22] = "Huawei MetaPad T 10s"; Name[23] = "Huawei MetaPad X2 ";
            Name[24] = "Huawei MetaPad 10 lite"; Name[25] = "Huawei Y7 Prime 2019";
            Name[26] = "Huawei Y6 Prime 2019"; Name[27] = " Huawei Y7a ";
            Name[28] = "Huawei Nova 7i"; Name[29] = "Huawei P Smart 2021";
            Name[30] = "Huawei Enjoy 20 SE"; Name[31] = "Huawei Meta 30 Pro 5G";
            Name[32] = "Huawei P5 Pro  "; Name[33] = "Huawei Meta 40 Pro ";
            Name[34] = "Huawei P40 Pro"; Name[35] = "Huawei P40 Pro Plus  ";

            Price[0] = 400; Price[1] = 500; Price[2] = 800;
            Price[3] = 630; Price[4] = 550; Price[5] = 1400;
            Price[6] = 580; Price[7] = 720; Price[8] = 790;
            Price[9] = 990; Price[10] = 515; Price[11] = 350;
            Price[12] = 237; Price[13] = 390; Price[14] = 215;
            Price[15] = 330; Price[16] = 310; Price[17] = 225;
            Price[18] = 110; Price[19] = 250;
            Price[20] = 130; Price[21] = 600; Price[22] = 225;
            Price[23] = 2750; Price[24] = 300; Price[25] = 240;
            Price[26] = 200; Price[27] = 185; Price[28] = 260;
            Price[29] = 230; Price[30] = 190; Price[31] = 1750;
            Price[32] = 1150; Price[33] = 1900; Price[34] = 1000;
            Price[35] = 1200; Price[36] = 240;



            do
            {
                for (int j = 0; j < 36; j++)
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

                    for (int i = 0; i < 36; i++)
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
            for (int j = 0; j < 36; j++)
            {
                for (int i = 0; i < 36; i++)
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
