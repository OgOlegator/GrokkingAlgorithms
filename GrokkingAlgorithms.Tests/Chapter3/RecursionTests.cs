using GrokkingAlgorithms.Tasks.Chapter3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tests.Chapter3
{
    public class RecursionTests
    {
        [Theory]
        [InlineData(6, 720)]
        [InlineData(5, 120)]
        [InlineData(4, 24)]
        [InlineData(3, 6)]
        [InlineData(2, 2)]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        public void GetFactorialByNumber(int number, int result)
        {
            Assert.Equal(new Recursion().GetFactorialByNumber(number), result);
        }
    }
}
