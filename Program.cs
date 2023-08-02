using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2_8_23_Assign_21
{
    class Program
    {
        static List<string> daysOfWeek = new List<string>
        {
            "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
        };

        static List<string> monthsOfYear = new List<string>
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September",
            "October", "November", "December"
        };

        static List<string> fruits = new List<string>
        {
            "Apple", "Banana", "Grapes", "Orange", "Strawberry", "Watermelon", "Mango", "Pineapple", "Cherry", "Pear"
        };

        static Dictionary<string, string> wordsAndMeanings = new Dictionary<string, string>
        {
            {"Apple", "A round fruit with red or green skin."},
            {"Banana", "A long, curved fruit with yellow skin."},
            {"Grapes", "Small, round fruit that grows in clusters."},
            {"Orange", "A citrus fruit with orange skin and juicy flesh."},
            {"Strawberry", "A small, red fruit with seeds on the surface."},
        };


        static void DisplayDays()
        {
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine($"Day: {day}");
                Thread.Sleep(2000);
            }
        }

        static void DisplayMonths()
        {
            foreach (string month in monthsOfYear)
            {
                Console.WriteLine($"Month: {month}");
                Thread.Sleep(2000);
            }
        }
        static void DisplayFruits()
        {
            foreach (var fruit in fruits)
            {
                Console.WriteLine("Fruits: " + fruit);
                Thread.Sleep(1000);
            }
        }

        static void DisplayFruitsAndWords()
        {
            foreach (string fruit in fruits)
            {
                string meaning = wordsAndMeanings.ContainsKey(fruit) ? wordsAndMeanings[fruit] : "Meaning not available";
                Console.WriteLine($"Fruit: {fruit} - Meaning: {meaning}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("------Welcome to Learning------");

            Thread daysThread = new Thread(DisplayDays);
            Thread monthsThread = new Thread(DisplayMonths);
            Thread fruitsThread = new Thread(DisplayFruits);
            Thread wordsThread = new Thread(DisplayFruitsAndWords);

            daysThread.Start();
            daysThread.Join();

            Thread.Sleep(5000);

            monthsThread.Start();
            monthsThread.Join();

            fruitsThread.Start();
            wordsThread.Start();

            fruitsThread.Join();
            wordsThread.Join();



            Console.WriteLine("\n Learning System Complete!");

            Console.ReadKey();
        }
    }
}
