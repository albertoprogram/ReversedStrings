using System;

namespace ReversedStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string / Ingrese una cadena por favor:");

            string str = Console.ReadLine();

            string strReversed = Solution(str);

            Console.WriteLine(strReversed);

            Console.WriteLine("do you wish to continue? / ¿Desea continuar?");
            Console.WriteLine("true or false");

            bool decision = Convert.ToBoolean(Console.ReadLine());

            if (decision == true)
            {
                Main(args);
            }
        }

        static string Solution(string str)
        {
            char[] strArray = str.ToCharArray();

            Array.Reverse(strArray);

            return new string(strArray);
        }
    }
}
