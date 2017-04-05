using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassHasslerChasenB
{
    class Employee
    {
        public string name { get; set; }
        public string title { get; set; }


        public Employee(string name, string title)
        {
            this.name = name;
            this.title = title;
        }

        public void TalkToCustomer(string customerName)
        {
            Console.WriteLine($"{name}: Hey {customerName}, how are you doing today?\n");
        }


        public void AskForID()
        {
            Console.WriteLine($"{name}: May I see your ID?");
        }

        public void AskForPreference()
        {
            Console.WriteLine($"{name}: What are you looking for today?");
        }
    }
}
