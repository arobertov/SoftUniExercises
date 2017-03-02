﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class AdvMessage
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                string randomPhrase = phrases[rnd.Next(phrases.Length)];
                string randomEvent = events[rnd.Next(events.Length)];
                string randomAuthor = authors[rnd.Next(authors.Length)];
                string randomCity = cities[rnd.Next(cities.Length)];

                Console.WriteLine("{0} {1} {2} - {3}", randomPhrase, randomEvent, randomAuthor, randomCity);
            }
        }
    }
}
