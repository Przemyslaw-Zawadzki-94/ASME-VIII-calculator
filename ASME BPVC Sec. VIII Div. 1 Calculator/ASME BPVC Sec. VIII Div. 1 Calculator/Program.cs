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
            double shellOutsideDiameter = 0;
            double shellWallThickness = 0;

            switch (action) 
            {
                case 1:
                {
                        Console.WriteLine("a) Enter shell outside diameter D_shell_ext [mm]");
                        shellOutsideDiameter = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("b) Enter shell wall thickness S_shell [mm]");
                        shellWallThickness = Convert.ToDouble(Console.ReadLine());





                        Console.WriteLine($"a) D_shell_ext = {shellOutsideDiameter}");
                        Console.WriteLine($"b) S_shell = {shellWallThickness}");

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