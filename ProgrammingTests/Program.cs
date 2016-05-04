using System;
using System.Linq;
using Data;
using Data.Interfaces;
using Entities;
using System.Collections.Generic;

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
            List<Company> allCompanies = _testRepository.FindAllCompanies();
            int countOfAllCompanies = allCompanies.Count();

            foreach (var employment in allCompanies.Where(c => c.Name=="Irish1").SelectMany(e => e.Employments))
            {
                Console.WriteLine(employment.Employee.Name);
            }

            double totalNumberOfyears = allCompanies.SelectMany(e => e.Employments).Select(y => y.NumberOfYearsEmployed).Sum(num => num);
        }

        public static void TestAlgorithms()
        {
            FizzBuzz();
            Console.ReadLine();

            Console.WriteLine("This is a programming test".ReverseWords());
            Console.ReadLine();

            Console.WriteLine("".ReverseWords());
            Console.ReadLine();

            string x = null;
            Console.WriteLine(x.ReverseWords());
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
             for (int i=1;i<101;i++)
            {
                bool printing = false;
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    printing = true;
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                    printing = true;
                }
                if (!printing)
                {
                    Console.Write(i.ToString());
                }
                Console.WriteLine();
                
            }
        }

 

    }
    public static class ExtensionMethods
    {

        /// <summary>
        /// </summary>
        /// <param name="sentence"></param>
        public static string ReverseWords(this string sentence)
        {
            /*
             * write a function to reverse the words in a string which 
             * does not use a framework reverse method
             * 
             * should test for nulls, empty string etc
             * 
             * Bonus Points if you can write this as an Extension Method
             */
            if (String.IsNullOrWhiteSpace(sentence))
            {
                return sentence;
            }


            return reverse("", "", sentence);

        }

        /// <summary>
        /// reverses each word in a sentence recursively
        /// </summary>
        /// <param name="reversed">the reversed string so far</param>
        /// <param name="temp">a temporary string for reversing each word</param>
        /// <param name="rest">the remainder of the string to be reversed</param>
        /// <returns></returns>
        private static string reverse(string reversed, string temp, string rest)
        {
            char[] separators = new char[] { ' ', '.', ';', ',' };

            if (String.IsNullOrEmpty(rest))
            {
                return reversed + temp;
            }
            if (separators.Contains(rest[0]))
            {
                return reverse(reversed + temp + rest[0], "", rest.Substring(1));
            }
            else
            {
                return reverse(reversed, rest[0] + temp, rest.Substring(1));
            }
        }
    }
}