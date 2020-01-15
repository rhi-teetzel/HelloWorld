using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)                   
        {
            string yourFirstName;
            string yourLastName;

            Console.WriteLine("Hello user, what is your first name?");
            yourFirstName = Console.ReadLine();
            Console.WriteLine("Thank you, now what is your last name?");
            yourLastName = Console.ReadLine();
            Console.WriteLine("Nice to meet you" + " " + yourFirstName + " " + yourLastName);

            int yourFirstNameLength = yourFirstName.Length;
            int yourLastNameLength = yourLastName.Length;

            if (yourFirstNameLength > yourLastNameLength)
            {
                Console.WriteLine("Your first name is longer than your last name.");
            }

            else if (yourFirstNameLength == yourLastNameLength)
            {
                Console.WriteLine("Your first and last names are the same length!");
            }

            else
                          
            {
                Console.WriteLine("Your last name is longer.");

              
            }
            Console.ReadKey();

        }
    }
}
