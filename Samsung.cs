using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Samsung:Cell_Phone
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
            Console.WriteLine("                                               << Sumsung >>               ");
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
            Console.WriteLine("|   1-  Samsung Galaxy A04s              |     170  $   |    21- Samsung Galaxy Tab S8 Plu   |    980  $   |");
            Console.WriteLine("|   2-  Samsung Galaxy A04               |     125  $   |    22- Samsung Galaxy A50          |    400  $   |");
            Console.WriteLine("|   3-  Samsung Galaxy A13               |     140  $   |    23- Samsung Galaxy Note 20 Plus |    1050 $   |");
            Console.WriteLine("|   4-  Samsung Galaxy A13G              |     135  $   |    24- Samsung Galaxy Note 10      |    728  $   |");
            Console.WriteLine("|   5-  Samsung Galaxy A23               |     175  $   |    25- Samsung Galaxy Note 10 Lite |    500  $   |");
            Console.WriteLine("|   6-  Samsung Galaxy  32 5G            |     260  $   |    26- Samsung Galaxy Note 9       |    566  $   |");
            Console.WriteLine("|   7-  Samsung Galaxy  Watch5 pro       |     370  $   |    27- Samsung Galaxy Note 8       |    500  $   |");
            Console.WriteLine("|   8-  Samsung Galaxy Watch5            |     240  $   |    28- Samsung Galaxy Note 10 Plus |    800  $   |");
            Console.WriteLine("|   9-  Samsung Galaxy M13               |     166  $   |    29- Samsung Galaxy A21s         |    200  $   |");
            Console.WriteLine("|   10- Samsung Galaxy  A13 (SM-A137)    |     165  $   |    30- Samsung Galaxy A51          |    235      |");
            Console.WriteLine("|   11- Samsung Galaxy A73  5G           |     500  $   |    31- Samsung Galaxy Tab S6 Lite  |    425  $   |");
            Console.WriteLine("|   12- Samsung Galaxy A53  5G           |     305  $   |    32- Samsung Galaxy A03s         |    150  $   |");
            Console.WriteLine("|   13- Samsung Galaxy M33               |     290  $   |    33- Samsung Galaxy A71          |    365  $   |");
            Console.WriteLine("|   14- Samsung Galaxy A33  5G           |     275  $   |    34- Samsung Galaxy A10          |    160  $   |");
            Console.WriteLine("|   15- Samsung Galaxy M53               |     338  $   |    35- Samsung Galaxy S21 Ultra 5G |    1000 $   |");
            Console.WriteLine("|   16- Samsung Galaxy Z Filp 4          |     1000 $   |    36- Samsung Galaxy A52s 5G      |    400  $   |");
            Console.WriteLine("|   17- Samsung Galaxy Flip3 5G          |     730  $   |    37- Samsung Galaxy M32          |    240  $   |");
            Console.WriteLine("|   18- Samsung Galaxy Z Fold4           |     1800 $   |    38- Samsung Galaxy A22          |    175  $   |");
            Console.WriteLine("|   19- Samsung Galaxy S22+ 5G           |     660  $   |    39- Samsung Galaxy M52 5G       |    439  $   |");
            Console.WriteLine("|   20- Samsung Galaxy S22 Ulter 5G      |     850  $   |    40- Samsung Galaxy M02s         |    120  $   |");
            Console.WriteLine("|   0-  Exit  t                          |              |                                    |             |");
            Console.WriteLine("|----------------------------------------|--------------|------------------------------------|-------------|");
            Console.WriteLine("|________________________________________|______________|____________________________________|_____________|");

            Console.WriteLine("\n\nDo You Want To End The Process ?, Enter (0)");



            Name[0] = "Samsung Galaxy A04sx "; Name[1] = "Samsung Galaxy A04";
            Name[2] = "Samsung Galaxy A13 "; Name[3] = "Samsung Galaxy A13G  ";
            Name[4] = "Samsung Galaxy A23"; Name[5] = "Samsung Galaxy  32 5G";
            Name[6] = "Samsung Galaxy  Watch5 pro"; Name[7] = "Samsung Galaxy Watch5";
            Name[8] = "Samsung Galaxy M13"; Name[9] = "Samsung Galaxy  A13 (SM-A137)";
            Name[10] = "Samsung Galaxy A73  5G"; Name[11] = " Samsung Galaxy A53  5G ";
            Name[12] = "Samsung Galaxy M33"; Name[13] = "Samsung Galaxy A33  5G ";
            Name[14] = "Samsung Galaxy M53  "; Name[15] = "Samsung Galaxy Z Filp 4 ";
            Name[16] = "Samsung Galaxy Flip3 5G "; Name[17] = "Samsung Galaxy Z Fold4";
            Name[18] = "Samsung Galaxy S22+ 5G "; Name[19] = "Samsung Galaxy S22 Ulter 5G ";


            Name[20] = " Samsung Galaxy Tab S8 Plu "; Name[21] = " Samsung Galaxy A50";
            Name[22] = "Samsung Galaxy Note 20 Plus "; Name[23] = "Samsung Galaxy Note 10 ";
            Name[24] = "Samsung Galaxy Note 10 Lite"; Name[25] = "Samsung Galaxy Note 9";
            Name[26] = "Samsung Galaxy Note 8"; Name[27] = "Samsung Galaxy Note 10 Plus";
            Name[28] = "Samsung Galaxy A21s"; Name[29] = "Samsung Galaxy A51";
            Name[30] = "Samsung Galaxy Tab S6 Lite"; Name[31] = " Samsung Galaxy A03s";
            Name[32] = "Samsung Galaxy A71 "; Name[33] = "Samsung Galaxy A52s 5G  ";
            Name[34] = "Samsung Galaxy S21 Ultra 5G "; Name[35] = "Samsung Galaxy Z Filp 4 ";
            Name[36] = "Samsung Galaxy M32 "; Name[37] = "Samsung Galaxy A22";
            Name[38] = "Samsung Galaxy M52 5G "; Name[39] = "Samsung Galaxy M02s";

            Price[0] = 170; Price[1] = 999; Price[2] = 140;
            Price[3] = 135; Price[4] = 175; Price[5] = 260;
            Price[6] = 370; Price[7] = 240; Price[8] = 166;
            Price[9] = 165; Price[10] = 500; Price[11] = 305;
            Price[12] = 290; Price[13] = 275; Price[14] = 338;
            Price[15] = 1000; Price[16] = 730; Price[17] = 1800;
            Price[18] = 660; Price[19] = 850;

            Price[20] = 980; Price[21] = 400; Price[22] = 1050;
            Price[23] = 728; Price[24] = 500; Price[25] = 566;
            Price[26] = 500; Price[27] = 800; Price[28] = 200;
            Price[29] = 235; Price[30] = 425; Price[31] = 150;
            Price[32] = 365; Price[33] = 160; Price[34] = 1000;
            Price[35] = 400; Price[36] = 240; Price[37] = 175;
            Price[38] = 439; Price[39] = 120;


            do
            {
                for (int j = 0; j < 40; j++)
                {
                    Num = 0;
                    Q = 0;

                    Console.Write("Choose  The Phone You Want To Buy  From The Menu : ");
                    Q = int.Parse(Console.ReadLine());
                    if (Q == 0)
                    {
                        break;
                    }
                    if (Q > 0 && Q <= 40)
                    {
                        Console.Write("How Many Phones  Do You Want Of This Type : ");
                        Num = int.Parse(Console.ReadLine());
                    }

                    for (int i = 0; i < 40; i++)
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
            for (int j = 0; j < 40; j++)
            {
                for (int i = 0; i < 40; i++)
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
