using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Gold:CenterEone
    {
        public string[] Name2 = new string[500];
        public double[] Price2 = new double[100];
        public string choice;

        public void print()
        {
            Console.WriteLine("\t\t\t\t-------------");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();

            Console.WriteLine("\t\t\t\t Choose Number The Kind Of Coin You Will Buy Gold with :");

            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t\t                    <<   Gold  >>               ");
            Console.WriteLine("\t\t\t\t            ------------------------------");
            Console.WriteLine("\t\t\t\t           --------------------------------");
            Console.WriteLine("\t\t\t\t_________-----------------------------------________");
            Console.WriteLine("\t\t\t\t|_______/__________________________________\\_______|");
            Console.WriteLine("\t\t\t\t|--------------------------------------------------|");
            Console.WriteLine("\t\t\t\t|--------------------------------------------------|");
            Console.WriteLine("\t\t\t\t|__________________________________________________|");
            Console.WriteLine("\t\t\t\t|--------------------------------------------------|");
            Console.WriteLine("\t\t\t\t| 1- $                          2- YAR             |");
            Console.WriteLine("\t\t\t\t| 3- SAR                        3- Exit            |");
            Console.WriteLine("\t\t\t\t|                                                  |");
            Console.WriteLine("\t\t\t\t|---------------------------------- ---------------|");
            Console.WriteLine("\t\t\t\t|__________________________________________________|");
            Console.Write("\t\t\t\t   Ener your choice  here ............ : ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Shawing();
                Print1();
            }

            else if (choice == "2")
            {
                Shawing2();
                Print2();
            }
            else if (choice == "3")
            {
                Shawing3();
                Print3();
            }
            else if (choice == "exit" || choice == "Exit")
            {
                Environment.Exit(0);
            }
        }



        public void Shawing()
        {


            double pr;
            /////////////////////////// put Colors //////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("-------------");
            Console.Clear();
            Console.WriteLine("------------ Type Of Golden  : --------------------");
            ///////////////////////////  for Jewelry Gold ////////////////////////////////////
            Name[0] = "Ring "; Name[1] = "Earrings Ear "; Name[2] = "Crowns"; Name[3] = "Bracelets"; Name[4] = "Loket";
            //////////////////////////// price when the user buying /////////////////////////
            Price[0] = 0.0; Price[1] = 0.0; Price[2] = 0.0; Price[3] = 0.0; Price[4] = 0.0;

            Sum = 0.0;
            //////////////////////////// Gramer for gold /////////////////////////////////

            Kg[0] = 0; Kg[1] = 0; Kg[2] = 0; Kg[3] = 0; Kg[4] = 0;
            Console.WriteLine("\t\t\t\t __________________________________________________");
            Console.WriteLine("\t\t\t\t|---------------------------|----------------------|");
            Console.WriteLine("\t\t\t\t|          Gold Type        |       Gold Type      |");
            Console.WriteLine("\t\t\t\t|---------------------------|----------------------|");
            Console.WriteLine("\t\t\t\t|___________________________|______________________|");
            Console.WriteLine("\t\t\t\t|                           |                      |");
            Console.WriteLine("\t\t\t\t| 1-  Ring                  | 2- Earrings Ear      |");
            Console.WriteLine("\t\t\t\t| 3-  Crowns                | 4- Bracelets         |");
            Console.WriteLine("\t\t\t\t| 5-  Loket                 |                      |");
            Console.WriteLine("\t\t\t\t| 0-  Exit                  |                      |");
            Console.WriteLine("\t\t\t\t|---------------------------|----------------------|");
            Console.WriteLine("\t\t\t\t|___________________________|______________________|");


            do
            {
                Num = 0;


                Console.Write("\t\t\t\t  Choose The Type Of Golden You Want To Buy : ");
                Q = int.Parse(Console.ReadLine());
                if (Q == 0)
                {
                    break;
                }
                Console.Write("\t\t\t\t   Enter The Gold Price The Currency  $ Dollar : ");
                pr = double.Parse(Console.ReadLine());
                if (Q > 0 && Q <= 5)
                {
                    Console.Write("\t\t\t\t   How Many Gram Do You Want : ");
                    Num = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < 5; i++)
                {
                    if (i == (Q - 1))
                    {
                        Name2[i] = Name[i];
                        Price[i] = Num * pr;
                        Sum +=Num * Price[i];
                        Kg[i] = Num;

                    }
                }
                Console.WriteLine("\t\t\t\t   If You Are Done Buying Select  (0)");
                /* if (Q == 0)
                 {
                     Environment.Exit(0);
                 }*/

            } while (Q != 0);








        }

        public void Print1()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Clear();

            Console.WriteLine("\t\t\t\t\t\t-------- AN ACOUNT BILL -----------");
            Console.WriteLine("\t\t\t\t________________________________________________________");
            Console.WriteLine("\t\t\t\t|           Name Gold        |    Gram   |   Price      |");
            Console.WriteLine("\t\t\t\t|----------------------------|-----------|--------------|");
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {


                    if (Name2[j] == Name[i])
                    {
                        Console.WriteLine("\t\t\t\t|" + ++counter + "- The {0,20:C} |   [{1,2:D}]\t |{2,15:C}", Name[j], Kg[j], Kg[j] * Price[j] + "  $    |");
                    }
                }

            }
            Console.WriteLine("\t\t\t\t|____________________________|___________|______________|");
            Console.Write("\t\t\t\t| TOTAL CLOUD :  {0,12:C} ", Sum + "$   ");
            Console.WriteLine("{0,27:D}", "          |");
            Console.Write("\t\t\t\t| Date :" + DateTime.Now);
            Console.WriteLine("{0,28:D}  ", "                         |");
            Console.WriteLine("\t\t\t\t|_______________________________________________________|");

            
        }



        ///////////////////////// Yemae \\\\\\\\\\\\\\\\\\\\\\\\\


        public void Shawing2()
        {


            double pr;
            /////////////////////////// put Colors //////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("-------------");
            Console.Clear();
            Console.WriteLine("\t\t\t\t------------ Type Of Golden  : --------------------");
            ///////////////////////////  for Jewelry Gold ////////////////////////////////////
            Name[0] = "Ring "; Name[1] = "Earrings Ear "; Name[2] = "Crowns"; Name[3] = "Bracelets"; Name[4] = "Loket";
            //////////////////////////// price when the user buying /////////////////////////
            Price[0] = 0.0; Price[1] = 0.0; Price[2] = 0.0; Price[3] = 0.0; Price[4] = 0.0;

            Sum = 0.0;
            //////////////////////////// Gramer for gold /////////////////////////////////

            Kg[0] = 0; Kg[1] = 0; Kg[2] = 0; Kg[3] = 0; Kg[4] = 0;
            Console.WriteLine("\t\t\t\t __________________________________________________");
            Console.WriteLine("\t\t\t\t|---------------------------|----------------------|");
            Console.WriteLine("\t\t\t\t|          Gold Type        |       Gold Type      |");
            Console.WriteLine("\t\t\t\t|---------------------------|----------------------|");
            Console.WriteLine("\t\t\t\t|___________________________|______________________|");
            Console.WriteLine("\t\t\t\t|                           |                      |");
            Console.WriteLine("\t\t\t\t| 1-  Ring                  | 2- Earrings Ear      |");
            Console.WriteLine("\t\t\t\t| 3-  Crowns                | 4- Bracelets         |");
            Console.WriteLine("\t\t\t\t| 5-  Loket                 |                      |");
            Console.WriteLine("\t\t\t\t| 0-  Exit                  |                      |");
            Console.WriteLine("\t\t\t\t|---------------------------|----------------------|");
            Console.WriteLine("\t\t\t\t|___________________________|______________________|");


            do
            {
                Num = 0;


                Console.Write("\t\t\t\t   Choose The Type Of Golden You Want To Buy : ");
                Q = int.Parse(Console.ReadLine());
                if (Q == 0)
                {
                    break;
                }
                Console.Write("\t\t\t\t   Enter The Gold Price The Currency  YAR :");
                pr = double.Parse(Console.ReadLine());
                if (Q > 0 && Q <= 5)
                {
                    Console.Write("\t\t\t\t   How Many Gram Do You Want : ");
                    Num = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < 5; i++)
                {
                    if (i == (Q - 1))
                    {
                        Name2[i] = Name[i];
                        Price[i] = Num * pr;
                        Sum += Num * Price[i];
                        Kg[i] = Num;

                    }
                }
                Console.WriteLine("\t\t\t\t   If You Are Done Buying Select  (0) \n");
                /* if (Q == 0)
                 {
                     Environment.Exit(0);
                 }*/

            } while (Q != 0);








        }

        public void Print2()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Clear();

            Console.WriteLine("\t\t\t\t\t\t-------- AN ACOUNT BILL -----------");
            Console.WriteLine("\t\t\t\t________________________________________________________");
            Console.WriteLine("\t\t\t\t|           Name Gold        |    Gram   |   Price      |");
            Console.WriteLine("\t\t\t\t|----------------------------|-----------|--------------|");
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {


                    if (Name2[j] == Name[i])
                    {
                        Console.WriteLine("\t\t\t\t|" + ++counter + "- The {0,20:C} |   [{1,2:D}]\t |{2,15:C}", Name[j], Kg[j], Kg[j] * Price[j] + "YAR   |");
                    }
                }

            }
            Console.WriteLine("\t\t\t\t|____________________________|___________|______________|");
            Console.Write("\t\t\t\t| TOTAL CLOUD :  {0,14:C} ", Sum + " YAR   ");
            Console.WriteLine("{0,25:D}", " |");
            Console.Write("\t\t\t\t| Date :" + DateTime.Now);
            Console.WriteLine("{0,28:D}  ", "                         |");
            Console.WriteLine("\t\t\t\t|_______________________________________________________|");

           
        }

        /////////////////////////// SAR /////////////////////////////////////

        public void Shawing3()
        {


            double pr;
            /////////////////////////// put Colors //////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("-------------");
            Console.Clear();
            Console.WriteLine("------------ Type Of Golden  : --------------------");
            ///////////////////////////  for Jewelry Gold ////////////////////////////////////
            Name[0] = "Ring "; Name[1] = "Earrings Ear "; Name[2] = "Crowns"; Name[3] = "Bracelets"; Name[4] = "Loket";
            //////////////////////////// price when the user buying /////////////////////////
            Price[0] = 0.0; Price[1] = 0.0; Price[2] = 0.0; Price[3] = 0.0; Price[4] = 0.0;

            Sum = 0.0;
            //////////////////////////// Gramer for gold /////////////////////////////////

            Kg[0] = 0; Kg[1] = 0; Kg[2] = 0; Kg[3] = 0; Kg[4] = 0;
            Console.WriteLine("\t\t\t\t __________________________________________________");
            Console.WriteLine("\t\t\t\t|---------------------------|----------------------|");
            Console.WriteLine("\t\t\t\t|          Gold Type        |       Gold Type      |");
            Console.WriteLine("\t\t\t\t|---------------------------|----------------------|");
            Console.WriteLine("\t\t\t\t|___________________________|______________________|");
            Console.WriteLine("\t\t\t\t|                           |                      |");
            Console.WriteLine("\t\t\t\t| 1-  Ring                  | 2- Earrings Ear      |");
            Console.WriteLine("\t\t\t\t| 3-  Crowns                | 4- Bracelets         |");
            Console.WriteLine("\t\t\t\t| 5-  Loket                 |                      |");
            Console.WriteLine("\t\t\t\t| 0-  Exit                  |                      |");
            Console.WriteLine("\t\t\t\t|---------------------------|----------------------|");
            Console.WriteLine("\t\t\t\t|___________________________|______________________|");


            do
            {
                Num = 0;


                Console.Write("\t\t\t\t   Choose The Type Of Golden You Want To Buy : ");
                Q = int.Parse(Console.ReadLine());
                if (Q == 0)
                {
                    break;
                }
                Console.Write("\t\t\t\t   Enter The Gold Price The Currency  SAR : ");
                pr = double.Parse(Console.ReadLine());
                if (Q > 0 && Q <= 5)
                {
                    Console.Write("\t\t\t\t   How Many Gram Do You Want : ");
                    Num = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < 5; i++)
                {
                    if (i == (Q - 1))
                    {
                        Name2[i] = Name[i];
                        Price[i] = Num * pr;
                        Sum += Num * Price[i];
                        Kg[i] = Num;

                    }
                }
                Console.WriteLine("\t\t\t\t   If You Are Done Buying Select  (0) \n");
                /* if (Q == 0)
                 {
                     Environment.Exit(0);
                 }*/

            } while (Q != 0);








        }

        public void Print3()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Clear();

            Console.WriteLine("\t\t\t\t\t\t-------- AN ACOUNT BILL -----------");
            Console.WriteLine("\t\t\t\t________________________________________________________");
            Console.WriteLine("\t\t\t\t|           Name Gold        |    Gram   |   Price      |");
            Console.WriteLine("\t\t\t\t|----------------------------|-----------|--------------|");
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {


                    if (Name2[j] == Name[i])
                    {
                        Console.WriteLine("\t\t\t\t|" + ++counter + "- The {0,20:C} |   [{1,2:D}]\t |{2,15:C}", Name[j], Kg[j], Kg[j] * Price[j] + "SAR   |");
                    }
                }

            }
            Console.WriteLine("\t\t\t\t|____________________________|___________|______________|");
            Console.Write("\t\t\t\t| TOTAL CLOUD :  {0,12:C} ", Sum + " SAR  ");
            Console.WriteLine("{0,27:D}", "          |");
            Console.Write("\t\t\t\t| Date :" + DateTime.Now);
            Console.WriteLine("{0,28:D}  ", "                         |");
            Console.WriteLine("\t\t\t\t|_______________________________________________________|");

            
        }
    }
}
