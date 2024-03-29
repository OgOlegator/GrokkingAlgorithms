﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tasks.Chapter2
{
    /// <summary>
    /// Сортировка выбором
    /// </summary>
    public static class SortingBySelection
    {
        public static int[] Execute(int[] arr)
        {
            var arrCopy = arr;
            var result = new int[arr.Length];

            for ( var i = 0; i < arr.Length; i++)
            {
                var smallestIndex = GetSmallestIndex(arrCopy);

                result[i] = arrCopy[smallestIndex];
                arrCopy = arrCopy.GetNewArrWithRemoveElement(smallestIndex);
            }

            return result;
        }

        /// <summary>
        /// Поиска индекса наименьшего элемента
        /// </summary>
        /// <param name="arr">Исходный массив</param>
        /// <returns>Индекс наименьшего элемента</returns>
        public static int GetSmallestIndex(int[] arr)
        {
            var smallestNumber = int.MaxValue;
            var smallestIndex = -1;

            for (var i = 0; i < arr.Length; i++)
                if (arr[i] < smallestNumber)
                { 
                    smallestNumber = arr[i]; 
                    smallestIndex = i;
                }

            return smallestIndex;
        }

        /// <summary>
        /// Создание нового массива без удаляемого элемента
        /// </summary>
        /// <param name="arr">Исходный массив</param>
        /// <param name="removeIndex">Индекс удаляемого элемента</param>
        /// <returns>Массив без удаленного элемента</returns>
        public static int[] GetNewArrWithRemoveElement(this int[] arr, int removeIndex)
        {
            var result = new int[arr.Length - 1];

            var resultIndex = 0;

            for(var i = 0; i < arr.Length; i++)
            {
                if (i == removeIndex)
                    continue;

                result[resultIndex] = arr[i];
                resultIndex++;
            }

            return result;
        }
    }
}
