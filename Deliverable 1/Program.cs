using System;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous? ");
            string vacationType = Console.ReadLine();
            Console.WriteLine("How many are in your group? ");
            int groupSize = int.Parse(Console.ReadLine());

            Console.Write("Since you’re a group of " + groupSize + " going on a " + vacationType + " vacation, you should take ");
            {
                if (groupSize <= 2)
                {
                    Console.Write("first class ");
                }
                else if (groupSize >= 6)
                {
                    Console.Write("a charter ");
                }
                else
                {
                    Console.Write("a helicopter ");
                }
            }
            {
                if (vacationType == "musical")
                {
                    Console.Write("to New Orleans.");
                }
                else if (vacationType == "tropical")
                {
                    Console.Write("for a beach vacation in Mexico.");
                }
                else if (vacationType == "adventurous")
                {
                    Console.Write("to go whitewater rafting the Grand Canyon.");
                }

            }
        }

    }
}