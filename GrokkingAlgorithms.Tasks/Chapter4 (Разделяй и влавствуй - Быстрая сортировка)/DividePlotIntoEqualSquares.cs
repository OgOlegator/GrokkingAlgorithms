using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tasks.Chapter4
{
    /// <summary>
    /// Разделить площадь участка на равные квадраты
    /// </summary>
    public class DividePlotIntoEqualSquares
    {
        //Представьте, что вы фермер, владеющий земельным участком.
        //Вы хотите равномерно разделить землю на одинаковые КВАДРАТНЫЕ участки.
        //Участки должны быть настолько большими, насколько это возможно.
        
        public int Execute(int a, int b)
        {
            if(a == 0 || b == 0) 
                return 0;

            GetLargerAndSmallerSides(a, b, out var bigSide, out var smallSide);

            if(bigSide % smallSide == 0)
                return smallSide;
            
            while (bigSide > smallSide)
                bigSide -= smallSide;

            return Execute(bigSide, smallSide);
        }

        private void GetLargerAndSmallerSides(int a, int b, out int bigSide, out int smallSide)
        {
            if(a > b)
            {
                bigSide = a;
                smallSide = b; 
            }
            else if(a < b)
            {
                smallSide = a;
                bigSide = b;
            }
            else
            { 
                bigSide = a; 
                smallSide = b; 
            }
        }
    }
}
