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
        {
            if (listNumbers.Count == 0)
                return 0;
            else
            {
                listNumbers.RemoveAt(0);
                return 1 + Execute(listNumbers);
            }
        }
    }
}
