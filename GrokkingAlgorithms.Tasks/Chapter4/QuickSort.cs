using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tasks.Chapter4
{
    /// <summary>
    /// Реализация алгоритма быстрой сортировки (по возрастанию)
    /// </summary>
    public class QuickSort
    {
        public List<int> Execute(List<int> listNumbers)
        {
            //Список с 1 или 0 элементами уже отсортирован
            if(listNumbers.Count < 2)
                return listNumbers;

            //Опорный элемент
            var supportElement = listNumbers[0];

            var greaterNums = Execute(listNumbers.Where(num => num > supportElement).ToList());

            var equalNums = listNumbers.Where(num => num == supportElement);

            var lessNums = Execute(listNumbers.Where(num => num < supportElement).ToList());

            var result = new List<int>();

            result.AddRange(lessNums);
            result.AddRange(equalNums);
            result.AddRange(greaterNums);

            return result;
        }
    }
}
