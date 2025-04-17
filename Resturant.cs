using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Resturant:CenterEone
    {
        public string[] Name2 = new string[500];
        public double[] Price2 = new double[500];



        public void Showing()
        {



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("____________________________________________________________________________________\n");

            Console.WriteLine("_____________________________WELCOM TO OUR RESTAURANT_______________________________\n");

            Console.WriteLine(" Choice from the menu you want or exit:");
            Console.WriteLine("|--------------------------------------MENU-----------------------------------------|");
            Console.WriteLine("|___________________________________________________________________________________|");
            Console.WriteLine("|---------------------------------------------------------|-------------------------|");
            Console.WriteLine("|_______________________ FOOD ____________________________|________ DRINKS _________|");
            Console.WriteLine("|---------------------------------------------------------|-------------------------|");
            Console.WriteLine("| 1-Foul Qllaa       1300 | 9-Plain Tawa Bread       150  | 17-Adani Tea       150  |");
            Console.WriteLine("| 2-Egg Bean         1500 | 10-Egg Tawa Bread         250 | 18-Karak Tea       100  |");
            Console.WriteLine("| 3-Wet Bean         700  | 11-Tawa Cheese Bread      200 | 19-Milk Tea        200  |");
            Console.WriteLine("| 4-Lick It          450  | 12-Tawa Cherrar Bread     400 | 20-Plain Tea       50   |");
            Console.WriteLine("| 5-Baked Eggs       500  | 13-Tawa Meat Bread        900 | 21-Turkish Coffee  250  |");
            Console.WriteLine("| 6-Fried Eggs       850  | 14-Egg Vegetable Mutabbaq 440 | 22-French Coffee   300  |");
            Console.WriteLine("| 7-Shakshuka Eggs   1300 | 15-Minced Meat Mutabbaq   750 | 23-Csppuccino      500  |");
            Console.WriteLine("| 8-Shakshuka Adeny 1600  | 16-Mutabbaq Liquid Chees  270 | 0-Exit                  |");
            Console.WriteLine("|_________________________._______________________________|_________________________|");


            Name[0] = "Foul Qllaa "; Name[1] = "Egg Bean   "; Name[2] = "Wet Bean  "; Name[3] = "Lick It "; Name[4] = "Baked Eggs ";
            Name[5] = "Fried Eggs "; Name[6] = "Shakshuka Eggs"; Name[7] = "Shakshuka Adeny "; Name[8] = "Plain Tawa Bread "; Name[9] = "Egg Tawa Bread ";
            Name[10] = "Tawa Cheese Bread"; Name[11] = "Foul Qllaa "; Name[12] = "Tawa Meat Bread  "; Name[13] = "Egg Vegetable Mutabbaq"; Name[14] = "Minced Meat Mutabbaq ";
            Name[15] = "Mutabbaq Liquid Chees"; Name[16] = "Adani Tea "; Name[17] = "Karak Tea"; Name[18] = "Milk Tea"; Name[19] = "Plain Tea";
            Name[20] = "Turkish Coffee"; Name[21] = "French Coffee "; Name[22] = "Csppuccino ";

            Price[0] = 1300; Price[1] = 1500; Price[2] = 700; Price[3] = 450; Price[4] = 500; Price[5] = 850;
            Price[6] = 1300; Price[7] = 1600; Price[8] = 150; Price[9] = 250; Price[10] = 200; Price[11] = 400;
            Price[12] = 900; Price[13] = 440; Price[14] = 750; Price[15] = 270; Price[16] = 150; Price[17] = 100;
            Price[18] = 200; Price[19] = 50; Price[20] = 250; Price[21] = 300; Price[22] = 500;

            Console.WriteLine("\n\nDo You Want To End The Process ?, Enter (0)");
            Console.WriteLine("OR Do You Want To Continue  ?, Enter Eny Number");


            do
            {
                for (int j = 0; j < 23; j++)
                {
                    Num = 0;
                    Q = 0;

                    Console.Write("Choose The Meal  You Want From The Menu : ");
                    Q = int.Parse(Console.ReadLine());
                    if (Q == 0)
                    {
                        break;
                    }
                    if (Q > 0 && Q <= 23)
                    {
                        Console.Write("How Many  Do You Want : ");
                        Num = int.Parse(Console.ReadLine());
                    }
                    else { Console.WriteLine("ERROR You Can't Choise This Number"); }

                    for (int i = 0; i < 23; i++)
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

        public void Print()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Clear();

            Console.WriteLine("\t\t\t\t\t\t-------- AN ACOUNT BILL -----------");
            Console.WriteLine("\t\t\t\t________________________________________________________");
            Console.WriteLine("\t\t\t\t|           Item Name        |  Number   |   Price      |");
            Console.WriteLine("\t\t\t\t|----------------------------|-----------|--------------|");
            for (int j = 0; j < 23; j++)
            {
                for (int i = 0; i < 23; i++)
                {


                    if (Name2[j] == Name[i])
                    {
                        Console.WriteLine("\t\t\t\t|" + ++counter + "- The {0,20:C} |   [{1,2:D}]\t |{2,15:C}", Name2[j], Kg[j], Kg[j] * Price2[j] + "  Real  |");
                    }
                }

            }
            Console.WriteLine("\t\t\t\t|____________________________|___________|______________|");
            Console.Write("\t\t\t\t| TOTAL CLOUD :  {0,12:C} ", Sum + " Real");
            Console.WriteLine("{0,27:D}", "          |");
            Console.Write("\t\t\t\t| Date :" + DateTime.Now);
            Console.WriteLine("{0,28:D}  ", "                         |");
            Console.WriteLine("\t\t\t\t|_______________________________________________________|");

           
        }
    }
}
