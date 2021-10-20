using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta sünniaasta.");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta ome perekonnanime:");
            string userLastname = Console.ReadLine();


            Greetings(userName, userLastname, userAge);


        }
        private static void Greetings(string someString, string anotherString, int someInt)
        {
            Console.WriteLine($"Tere, {someString} {anotherString}!");
            Console.WriteLine($"Oled {2021 - someInt}.");
        }
    }
}
