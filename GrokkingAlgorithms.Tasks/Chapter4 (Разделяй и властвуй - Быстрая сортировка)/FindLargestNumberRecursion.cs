using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tasks.Chapter4
{
    /// <summary>
    /// Поиск наименьшегно числа в списке рекурсивно
    /// </summary>
    public class FindLargestNumberRecursion
    {
        public int Execute(List<int> numbers)
        {
            if(numbers.Count == 0) 
                throw new ArgumentException();

            var currentNumber = numbers.First();

            if (numbers.Count == 1)
                return currentNumber;

            var subMax = Execute(numbers.Skip(1).ToList());

            return currentNumber > subMax ? currentNumber : subMax;
        }
    }
}
