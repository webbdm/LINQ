using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{

    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }

    public class Bank
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            var LFruits = from fruit in fruits
                          where fruit.StartsWith("L")
                          select fruit;

            // foreach (string fruit in LFruits)
            // {
            //     Console.WriteLine($"{fruit}");
            // }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };


            var fourAndSixMultiples = numbers.Where(number => (number % 4 == 0) || (number % 6 == 0));

            // foreach (int number in fourAndSixMultiples)
            // {
            //     Console.WriteLine($"{number}");
            // }

            // Order these student names alphabetically, in descending order (Z to A
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            var descend = names.OrderByDescending(name => name);

            // foreach (string name in descend)
            // {
            //     Console.WriteLine($"{name}");
            // }

            // Build a collection of these numbers sorted in ascending order
            List<int> nummies = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            //var ascendingNumbers = nummies.OrderBy(number => number);

            var orderedNums =
                from numnum in nummies
                orderby numnum
                select numnum;

            // foreach (int num in orderedNums)
            // {
            //     Console.WriteLine(num);
            // }

            // Output how many numbers are in this list
            List<int> nums = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            //var numberCount = nums.Count();
            Console.WriteLine(nums.Count());

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            Console.WriteLine($"${purchases.Sum()}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            // Console.WriteLine("Max");
            // Console.WriteLine(prices.Max());

            /*
               Store each number in the following List until a perfect square
               is detected.
               Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
           */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            var numsUntilPerfectSquare =
                wheresSquaredo.TakeWhile(num => Math.Sqrt(num) % 1 != 0);

            // Console.WriteLine("Squaredo!");
            // foreach (var num in numsUntilPerfectSquare)
            // {
            //     Console.WriteLine(num);
            // }

            // Build a collection of customers who are millionaires
            // List<Customer> customers = new List<Customer>()
            // {
            //     new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            //     new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            //     new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            //     new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            //     new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            //     new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            //     new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            //     new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            //     new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            //     new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            // };

            // var millionaires = from customer in customers
            //                    where customer.Balance >= 1000000
            //                    select customer;

            Console.WriteLine("Millionaires");
            // foreach (var person in millionaires)
            // {
            //     Console.WriteLine(person.Name);
            // }

            // var twoCommas = from person in millionaires
            //                 group person by person.Bank into thing
            //                 select new { Bank = thing.Key, NumCustomers = thing.Count() };

            // foreach (var bankie in twoCommas)
            // {
            //     Console.WriteLine($"{bankie.Bank} has {bankie.NumCustomers} millionaires");
            // }

            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

            // Create some customers and store in a List
            List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };



            var bankPeople = from bank in banks
                             join customer in customers on bank.Symbol equals customer.Bank
                             select new { Bank = bank.Name, Name = customer.Name };

             foreach (var customer in bankPeople)
            {
                Console.WriteLine($"{customer.Name} stores their goodies at {customer.Bank}");
            }




        }
    }
}
