using GrokkingAlgorithms.Tasks.Chapter4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tests.Chapter4
{
    public class DividePlotIntoEqualSquaresTests
    {
        [Theory]
        [InlineData(1680, 640, 80)]
        [InlineData(1800, 700, 100)]
        [InlineData(4, 2, 2)]
        [InlineData(100, 0, 0)]
        public void Execute(int a, int b, int expected)
        {
            var actual = new DividePlotIntoEqualSquares().Execute(a, b);

            Assert.Equal(expected, actual);
        }
    }
}
