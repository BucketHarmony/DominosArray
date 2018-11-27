using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominosArray.BusinessLogic
{
    class MissingNumberFinder
    {

        public int Find(List<int> NumberList)
        {
            // Confirm that the array is not empty
            if (!NumberList.Any()) { throw new ArgumentException("Array should not be empty."); }
            
            // Sort the array
            List<int> SortedList = NumberList.OrderBy(i => i).ToList();

            // Get highest and Lowest
            int highestInt = SortedList[SortedList.Count - 1];
            int lowestInt = SortedList[0];
            int count = SortedList.Count;

            // confirm that there is only one missing number
            if((highestInt - lowestInt) != count) { throw new ArgumentException("Array should not have exacly 1 missing number in array."); }

            // use Enumerable magic to find missing integer(s)
            List<int> resultList = Enumerable.Range(lowestInt, count).Except(NumberList).ToList();

            // confirm that there is only one missing integer
            if (resultList.Count >= 2) { throw new ArgumentException("Array should not have more than 1 missing number in array."); }

            // return the results
            return resultList[0];
        }
    }
}
