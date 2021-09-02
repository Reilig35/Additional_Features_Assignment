using System;

namespace Additional_Features_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string COUNTRY = "Ireland";
            

            Console.WriteLine($"Welcome to {COUNTRY}\nPlaese answer the following questions to help us process your entry:");
            Console.WriteLine("Are you travelling from inside the European Union?");
            var EU = Console.ReadLine().ToLower();
            if (EU == "yes" || EU == "yeah" || EU == "yup" || EU == "y")
            {
                Console.WriteLine("Please enter your first name: ");
                var fName = Console.ReadLine();
                Console.WriteLine("Please enter your last name: ");
                var lName = Console.ReadLine();
                Console.WriteLine($"How much money are you brining into {COUNTRY} in euros:");
                decimal Money = Convert.ToDecimal(Console.ReadLine());

                Person traveller = new Person(fName, lName, Money);
                Console.WriteLine($"Thank you {traveller.fName} {traveller.lName} you are entering {COUNTRY} with {traveller.Money} euros.\n" +
                    $"Please enjoy your visit.");
            }
            else if (EU == "no" || EU == "nope" || EU == "na" || EU == "n")
            {
                Console.WriteLine("Please enter your first name: ");
                var fName = Console.ReadLine();
                Console.WriteLine("Please enter your last name: ");
                var lName = Console.ReadLine();
                Person traveller = new Person(fName, lName);
                Console.WriteLine($"Thank you {traveller.fName} {traveller.lName} you are clear to enter ${COUNTRY}.\n" +
                    $"Please enjoy your visit.");
            }
            else Console.WriteLine("Sorry could not understand input please try again.");
        }
    }
}

                







