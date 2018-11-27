using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominosArray.BusinessLogic;

namespace DominosArray
{
    class Program
    {
        static MissingNumberFinder Finder = new MissingNumberFinder();

        static void Main(string[] args)
        {
            var listOne = new List<int> { 1, 2, 4 };
            ProcessAndDisplayArray(listOne);

            var listTwo = new List<int> { 1, 2, 3, 4, 5, 6, 8, 9 };
            ProcessAndDisplayArray(listTwo);

            var listThree = new List<int> { 1, -1 };
            ProcessAndDisplayArray(listThree);

            var listFour = new List<int> { 8, 6, 7, 5, 3, 1, 9, 4 };
            ProcessAndDisplayArray(listFour);

            var listFive = new List<int> { 1, 0, -1, -3, -4};
            ProcessAndDisplayArray(listFive);

            try
            {
                var listEmpty = new List<int> {};
                ProcessAndDisplayArray(listEmpty);
            }
            catch(Exception ex)
            {
                DisplayError(ex.Message);
            }

            try
            {
                var listSkipTwo = new List<int> { 1, 2, 3, 4, 7, 8 };
                ProcessAndDisplayArray(listSkipTwo);
            }
            catch(Exception ex)
            {
                DisplayError(ex.Message);
            }

            try
            {
                var listMissingNone = new List<int> { 1, 2, 3, 4, 5 };
                ProcessAndDisplayArray(listMissingNone);
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }

            Console.WriteLine("Press any key to continue");
            Console.Read();
        }

        private static void ProcessAndDisplayArray(List<int> NumberList)
        {
            DisplayArray(NumberList);
            int result = Finder.Find(NumberList);
            DisplayResults(result);
        }

        private static void DisplayArray(List<int> NumberList)
        {
            Console.WriteLine("Testing the following array of integers:");
            foreach (var item in NumberList)
            {
                Console.Write("{0} ", item.ToString());
            }
            Console.WriteLine();
        }

        private static void DisplayResults(int MissingNumber)
        {
            Console.WriteLine("The missing number was: {0} ", MissingNumber);
            Console.WriteLine();
        }
        private static void DisplayError(string Message)
        {
            Console.WriteLine("This array did not work");
            Console.WriteLine(Message);
            Console.WriteLine();
        }
    }
}
