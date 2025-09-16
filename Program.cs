using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("first Number input:");
            int.TryParse(Console.ReadLine(), out int n1);
            Console.Write("second numbers input:");
            int.TryParse(Console.ReadLine(), out int n2);
            Console.WriteLine("Enter Your choice:");
            int.TryParse(Console.ReadLine(), out int userchoice);

            Console.WriteLine("Result: " + Calculetor(n1, n2, userchoice));
        }   
        static int Calculetor(int n1, int n2, int userchoice)
        {
            if (userchoice == 1)
            {
                return n1 + n2;
            }
            else if (userchoice == 2)
            {
                return n1 - n2;
            }
            else if (userchoice == 3)
            {
                return n1 * n2;
            }
            else if (userchoice == 4)
            {
                return n1 / n2;
            }
            else
            {
                Console.WriteLine("invalid choice");
                return 0;
            }
        }
    }
}