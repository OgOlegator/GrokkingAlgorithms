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
            => listNumbers.Count == 0
                ? 0
                : listNumbers.First() + Execute(listNumbers.Skip(1).ToList());
    }
}
