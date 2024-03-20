using GrokkingAlgorithms.Tasks.Chapter4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tests.Chapter4
{
    public class SumRecursionTests
    {
        [Theory]
        [InlineData("1 7 8 2 4", 22)]
        [InlineData("7 8 2 4", 21)]
        [InlineData("7 8 4", 19)]
        [InlineData("7 8", 15)]
        [InlineData("8", 8)]
        public void Execute(string inputArr, int expected)
        {
            var actual = new SumRecursion().Execute(inputArr.Split(' ').Select(element => int.Parse(element)).ToList());

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Execute_WithEmptyList()
        {
            Assert.Equal(0, new SumRecursion().Execute(new List<int>()));
        }
    }
}
