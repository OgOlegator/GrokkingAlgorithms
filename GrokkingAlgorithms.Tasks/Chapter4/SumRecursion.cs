using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tasks.Chapter4
{
    /// <summary>
    /// Сумма всех элементов списка рекурсивно
    /// </summary>
    public class SumRecursion
    {
        /// <returns>Сумма</returns>
        public int Execute(List<int> listNumbers)
        {
            if (listNumbers.Count == 0)
                return 0;
            else
            {
                 var firstNumber = listNumbers.First();
                 listNumbers.RemoveAt(0);
                 return firstNumber + Execute(listNumbers);
            }
        }
    }
}
