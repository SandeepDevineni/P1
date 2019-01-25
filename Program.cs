using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Northwest Taxi");
            String name;
            Console.WriteLine("Please Enter your name to continue:");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            char yourspecify= ' ';

            double farePrice;
            while (yourspecify != 'n'){
            Console.WriteLine("Select one of the destinations \n 1.St.Joseph \n 2.MCI \n 3.Kansas City \n ");
            int specify = Convert.ToInt16(Console.ReadLine());

                switch (specify)
                {
                    case 1:
                        Console.WriteLine("Your destination is St.Joseph\n");
                        Console.WriteLine($"Your fare price is $70");

                        farePrice = TotalfarePrice("St.Joseph");
                        Console.WriteLine($"Your fare price including tax is: ${farePrice}");
                        break;
                    case 2 :
                        Console.WriteLine("Your destination is MCI\n");
                        Console.WriteLine($"Your fare price is $110");

                        farePrice = TotalfarePrice("MCI");
                        Console.WriteLine($"Your fare price including tax is: ${farePrice}");
                        break;
                    case 3:
                        Console.WriteLine("Your destination is Kansas City");
                        Console.WriteLine($"Your fare price is $130");
                        farePrice = TotalfarePrice("Kansas City");
                        Console.WriteLine($"Your fare price including tax is: ${farePrice}");
                        break;
                    default:
                        Console.WriteLine("Enter a valid input ");
                        break;
                }
                Console.WriteLine("Enter if you want to select other destination");
                yourspecify = Convert.ToChar(Console.ReadLine());


            }
        }

        public static double TotalfarePrice(String destination)
        {
            double tax = 0.082;
            if (destination == "St.Joseph")
            {
                return 70 +( 70 * Convert.ToDouble(tax));
            }
            if (destination == "MCI")
            {
                return 110 + (110 * Convert.ToDouble(tax));
            }
            if (destination == "Kansas City")
            {
            return 130 + (130 * Convert.ToDouble(tax));
             }
                return 0.0;
            }
            
        
        }
        
    }
   
        

