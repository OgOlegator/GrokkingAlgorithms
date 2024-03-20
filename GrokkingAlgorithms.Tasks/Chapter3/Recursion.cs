using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tasks.Chapter3
{
    public class Recursion
    {
        /// <summary>
        /// Расчет факториала числа
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns></returns>
        public int GetFactorialByNumber(int number)
        {
            for(var i = number; i != 0; i--)
                if(i == 1)
                    return i;
                else 
                    return i * GetFactorialByNumber(i - 1);

            return number;
        }
    }
}
