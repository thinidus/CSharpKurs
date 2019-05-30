using System;

namespace Hello
{
    class Program
    {
        private static string name;

        static void Main(string[] args)
        {

            ValueTypes();

            while (true)
            {
                Greetings();
                Age();
                Settings();

            }
        }

        /// <summary>
        /// Sprawdzanie zakresów typów liczb
        /// </summary>

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("MaxInt: " + maxInt);
            Console.WriteLine("MinInt: " + minInt);
            Console.WriteLine("MaxLong: " + maxLong);
            Console.WriteLine("MinLong: " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>

        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Wpisujemy wiek użytkownika
        /// </summary>


        private static void Age()
        {
            Console.WriteLine("Wpisz ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.WriteLine(name + " napij się piwa");
            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Użytkowniku wprowadziłeś niepoprawny wiek");
            }
            else
            {
                Console.WriteLine(name + " napij się mleka");
            }
        }

        /// <summary>
        /// Powitanie użytkownika
        /// </summary>

        private static void Greetings()
        {
            Console.WriteLine("Wpisz swoje imię: ");
            name = Console.ReadLine();
            Console.WriteLine("Witaj " + name);
            
        }
    }
}
