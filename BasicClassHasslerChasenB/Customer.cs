using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicClassHasslerChasenB
{
    class Customer
    {
        public string name { get; set; }

        public string preference { get; set; }

        public int id { get; set; }



        public Customer (string name, int id, string preference)
        {
            this.name = name;
            this.id = id;
            this.preference = preference;
        }

        private int DetermineMood()
        {
            Random rand = new Random();
            return rand.Next(0, 3);
        }

        public void Respond()
        {
            var responses = new[]
            {
                @"I'm good, thanks.",
                @"Terrible. I have had an absolutely terrible day.",
                @"I'm okay, could be better"
            };

            int mood = DetermineMood();
            Console.WriteLine($"{name}: {responses[mood]}");
        }
    }
}
