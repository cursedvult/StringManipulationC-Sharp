using System;

namespace newLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 19;
            string name = "Gustavo";
            int cars = 14;
            string nameCompany = "Mercedes-Benz";

            string[] hobbies = {"Playing videogames", "developing programs", "go out with my friends", "playing the guitar" };

            //String formating
            //uses indexes
            Console.WriteLine("String formatting");
            Console.WriteLine("Hello, my name is {0} and I am {1} years old", name, age);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Here at the {0} concessionaire we have {1} models to display", nameCompany, cars);
            Console.ReadKey();
            Console.Clear();
            //Console.WriteLine("Hello! my name is {0}, I'm {1} years old, and my hobbies consist of {3}", name, age, hobbies[0] );


            //String Interpolation
            //Starts with a dollar sign 
            //You can put variables directly through the string statement, without having to index them
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello, my name is {name} , I am {age} years old, and my hobbies consist of {hobbies[0]}, {hobbies[1]}, {hobbies[2]} and {hobbies[3]}. ");

            Console.ReadKey();
            Console.Clear();

            //Verbatim strings.
            /* these strings start with an @ and tell the compiler to take
             * the string literally, adding any spaces and ignoring any escape characters
             * like \n */

            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit,
sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad
minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
