using System;
using System.Linq;
using Data;
using Data.Interfaces;

namespace ProgrammingTests
{
    public class Program
    {
        private static ITestRepository _testRepository; 

        private static void Main(string[] args)
        {
            // instantiate the Test Repo
            _testRepository = new TestRepository();

            /*
             * Object Model redesign and implementation tasks
             * 
             * 1. Read through the object model and data used to create our test repository
             * 2. Write an abstract class from which IrishCompany, SoleTrader and ForeignCompany will inherit
             * 3. Write an Interface for the Address Class, implement it and refactor 
             *    all classes which require an address to use the new interface instead. 
             * 4. Implement FindAllCompanies method in Test Repository
             * 5. Implement NumberOfYearsEmployed property on Employment.
             */

            /*
             *  Linq queries and Algorithms
             * 
             * 1. Get Count of all Companies(Sole traders, Irish and Foreign Companies) in the "Database"
             * 2. Write a linq query to find all Employees still employed by Company "Irish1" and write out their names
             * 3. Write a query to find the total number of years that all employees (still employed or not) have worked.               
             * 
             * 4. Implement the FizzBuzz method below exactly to requirements
             * 5. Implement ReverseWords to requirements, taking case that it 
             *    doesn't fail for any of the cases in TestAlgorithms
             * 
             */

            TestAlgorithms();
            TestLinqQueries();
        }

        public static void TestLinqQueries()
        {
        }

        public static void TestAlgorithms()
        {
            FizzBuzz();
            Console.ReadLine();

            ReverseWords("This is a programming test");
            Console.ReadLine();

            ReverseWords("");
            Console.ReadLine();

            ReverseWords(null);
            Console.ReadLine();

        }


        /// <summary>
        /// </summary>
        public static void FizzBuzz()
        {
            /*
                Fizz Buzz
             * 
             * using an array from 1 - 100
             * 
             * Print the word "Fizz" for each multiple of 3
             * Print the word "Buzz" for each multiple of 5
             * Print the word "FizzBuzz" for each multiple of 3 & 5
             * else print the number
             * 
             */
        }

        /// <summary>
        /// </summary>
        /// <param name="sentance"></param>
        public static string ReverseWords(string sentance)
        {
            string revrsed = "";

            if (string.IsNullOrEmpty(sentance))
            {
                return "";
            }
            string[] sArray = sentance.Split(' ');

            for (int i = sArray.Length - 1; i < -1; i--)
            {
                revrsed += sArray[i];
            }
            return revrsed; 
            /*
                write a function to reverse the words in a string
             * 
             * should test for nulls, empty string etc
             * 
             * Bonus Points if you can make this function into an Extension Method
             */
        }
    }
}