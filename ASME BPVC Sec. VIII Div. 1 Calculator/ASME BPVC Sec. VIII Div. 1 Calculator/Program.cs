using System;


namespace ASME_BPVC_Sec._VIII_Div._1_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("This is simply calculator for pressure parts acc. to ASME BPVC Sec. VIII Div. 1");
            Console.WriteLine("\nwhat do you want to calculate?");
            Console.WriteLine("\nPress 1 for cylindrical shell");
            Console.WriteLine("\nPress 0 to exit");

            int action = Convert.ToInt32(Console.ReadLine());


            switch (action) 
            {
                case 1:
                {
                        Console.WriteLine("Enter shell outside diameter D_ext [mm]");
                        int shellOutsideDiameter = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"D_ext = {shellOutsideDiameter}");
                        break;
                }

                case 0:
                {
                    Console.WriteLine("See you!");
                    break;
                }
            }
        }
    }
}