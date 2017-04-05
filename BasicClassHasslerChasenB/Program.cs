using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Drawing;
using System.Windows.Input;

namespace BasicClassHasslerChasenB
{
    class Program
    {
        static void Main(string[] args)
        {
            var asciiArt = new[]
            {
                @"                                                               \________",
                @"                                                             ~  \######/",
                @"                                                              ~  |####/",
                @"                                                             ~   |____.",
                @"                                                            _____o____o"
            };

            Console.WriteLine("Please enter full screen mode before continuing.");
            Console.WriteLine("Please press enter to continue through each event...");

            Console.ReadKey();

            Console.WriteLine("\n\n");

            Console.WriteAscii("Welcome To The Market", Color.PeachPuff);

            foreach (string line in asciiArt)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("\n\n");

            Customer barry = new Customer("Barry", 1234, "Vegetables");
            Employee chuck = new Employee("Chuck", "Manager");

            chuck.TalkToCustomer(barry.name);
            Console.ReadKey();
            barry.Respond();
            Console.ReadKey();
            chuck.AskForPreference();
            Console.ReadKey();
            Console.WriteLine($"{barry.name}: {barry.preference}");
            Console.ReadKey();
            chuck.AskForID();
            Console.ReadKey();
            Console.WriteLine($"{barry.name}: Here ya go - {barry.id}");
            Console.ReadKey();

            Console.WriteLine($"{chuck.name}: Awesome. Aisle 8, right next to the rest of the produce. Thanks for choosing");
            Console.WriteAscii("The Market", Color.Pink);

            Console.Read();
        }

        

   
    }
}
