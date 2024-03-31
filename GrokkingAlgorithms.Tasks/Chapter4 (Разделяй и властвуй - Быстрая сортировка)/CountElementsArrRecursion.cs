using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tasks.Chapter4
{
    /// <summary>
    /// Подсчитать количество элементов в списке рекурсивно
    /// </summary>
    public class CountElementsArrRecursion
    {
        public int Execute(List<int> listNumbers)
            => listNumbers.Count == 0 
                ? 0 
                : 1 + Execute(listNumbers.Skip(1).ToList());
    }
}
