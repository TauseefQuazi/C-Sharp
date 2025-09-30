using System;


namespace Task1
{
    internal class Program
    {
        static int Vowels(string Text)
        {
            int Count = 0;

            foreach(char i in Text.ToLower())
            {
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                {
                    Count++;
                }
            }
            return Count;

        }
        static int Consonant(string Text)
        {
            int count = 0;
            foreach(char i in Text.ToLower())
            {
                if (!(i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u' || i == '1' || i == '2' || i == '3' || i == '4' || i == '5' || i == '6' || i == '7' || i == '8' || i == '9'))
                {
                    count++;
                }
            }
            return count;
        }
        static int Numbers(string Text)
        {
            int count = 0;
            foreach(char i in Text)
            {
                if (i == '1' || i == '2' || i == '3' || i == '4' || i == '5' || i == '6' || i == '7' || i == '8' || i == '9')
                {
                    count++;
                }
                
            }
            return count;

        }
        static void Main()
        {
            Console.Write("Enter any Text: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(Vowels(userInput));
            Console.WriteLine(Consonant(userInput));
            Console.WriteLine(Numbers(userInput));
        }
    }
}
