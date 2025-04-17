using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CurrencyConversion:Currency
    {
        public string[] curr = new string[500];
        public string choiceCurr;


        public void printCurr()
        {


            int i = 0;
            do
            {

                i++;


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();


                Console.WriteLine("\t\t\t\t_____________________________________________\n");
                Console.WriteLine("\t\t\t\t____________ Welcome To The Exchange Bank________\n\n");
                Console.WriteLine("\t\t\t\t Choice currency you want to convert or exit:");
                Console.WriteLine("\t\t\t\t|-----------------------------------------------------|");
                Console.WriteLine("\t\t\t\t|                                                     |");
                Console.WriteLine("\t\t\t\t| 1- YER TO $                      2- YER TO SAR      |");
                Console.WriteLine("\t\t\t\t| 3- $ TO YER                      4- $ TO SAR        |");
                Console.WriteLine("\t\t\t\t| 5- SAR TO YER                    6- SAR TO $        |");
                Console.WriteLine("\t\t\t\t| 0- Exit                                             |");
                Console.WriteLine("\t\t\t\t|-----------------------------------------------------|");
                Console.WriteLine("\t\t\t\t|_____________________________________________________|\n");


                Console.Write("\t\t\t\t   Enter your choice  here : ");
                choiceCurr = Console.ReadLine();
                if (choiceCurr == "1")
                {
                    conv1();
                    Console.ReadKey();
                }

                else if (choiceCurr == "2")
                {

                    conv2();
                    Console.ReadKey();
                }


                else if (choiceCurr == "3")
                {
                    conv3();
                    Console.ReadKey();
                }

                else if (choiceCurr == "4")
                {
                    conv4();
                    Console.ReadKey();
                }

                else if (choiceCurr == "5")
                {
                    conv5();
                    Console.ReadKey();
                }

                else if (choiceCurr == "6")
                {
                    conv6();
                    Console.ReadKey();
                }

                else if (choiceCurr == "0")
                {
                    break;
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("_____________________________________________\n");
                    Console.WriteLine("ERROR YOU CAN JUST CHOICE NUMBER FROM 1 TO 6 and 0 to exit !!!!!!!!");
                    Console.ReadKey();
                }


            }
            while (choiceCurr != "0");



        }

        public void conv1()
        {
            t = 559.75;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.WriteLine("_____________________________________________\n");


            Console.WriteLine("How much YER do you have to convert to $ ? ");
            f = int.Parse(Console.ReadLine());
            if (f <= 0)
            { Console.WriteLine("ERROR CAN NOT CONVERT MONEY LESS THAN ZERO !!!!!!!!!!!"); }
            else
            {
                Console.WriteLine("Total :"+ (f / t) + "$");
            }

        }



        public void conv2()
        {
            double f, t = 148.60;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.WriteLine("_____________________________________________\n");


            Console.WriteLine("How much YER do you have to convert to SAR ? ");
            f = int.Parse(Console.ReadLine());
            if (f <= 0)
            { Console.WriteLine("ERROR CAN NOT CONVERT MONEY LESS THAN ZERO !!!!!!!!!!!"); }
            else
            {
                Console.WriteLine("Total : " + (f / t) + "SAR");
            }

        }


        public void conv3()
        {
            t = 559;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.WriteLine("_____________________________________________\n");


            Console.WriteLine("How much $ do you have to convert YER ? ");
            f = int.Parse(Console.ReadLine());
            if (f <= 0)
            { Console.WriteLine("ERROR CAN NOT CONVERT MONEY LESS THAN ZERO !!!!!!!!!!!"); }
            else
            {
                Console.WriteLine("Total : " + (f * t) + "YER");
            }

        }

        public void conv4()
        {
            t = 3.75;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.WriteLine("_____________________________________________\n");


            Console.WriteLine("How much $ do you have to convert SAR ? ");
            f = int.Parse(Console.ReadLine());
            if (f <= 0)
            { Console.WriteLine("ERROR CAN NOT CONVERT MONEY LESS THAN ZERO !!!!!!!!!!!"); }
            else
            {
                Console.WriteLine("Total : " + (f * t) + "SAR");
            }

        }

        public void conv5()
        {
            t = 148.40;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.WriteLine("_____________________________________________\n");


            Console.WriteLine("How much SAR do you have to convert YER ? ");
            f = int.Parse(Console.ReadLine());
            if (f <= 0)
            { Console.WriteLine("ERROR CAN NOT CONVERT MONEY LESS THAN ZERO !!!!!!!!!!!"); }
            else
            {
                Console.WriteLine("Total : " + (f * t) + "YER");
            }

        }

        public void conv6()
        {
            t = 3.75;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.WriteLine("_____________________________________________\n");


            Console.WriteLine("How much SAR do you have to convert $ ? ");
            f = int.Parse(Console.ReadLine());
            if (f <= 0)
            { Console.WriteLine("ERROR CAN NOT CONVERT MONEY LESS THAN ZERO !!!!!!!!!!!"); }
            else
            {
                Console.WriteLine("Total : " + (f / t) + "$");
            }

        }
    }
}
