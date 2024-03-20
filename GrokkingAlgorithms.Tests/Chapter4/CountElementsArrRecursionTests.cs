using GrokkingAlgorithms.Tasks.Chapter4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tests.Chapter4
{
    public class CountElementsArrRecursionTests
    {
        [Theory]
        [InlineData("1 7 8 2 4", 5)]
        [InlineData("7 8 2 4", 4)]
        [InlineData("7 8 4", 3)]
        [InlineData("7 8", 2)]
        [InlineData("8", 1)]
        public void Execute(string inputArr, int expected)
        {
            var actual = new CountElementsArrRecursion().Execute(inputArr.Split(' ').Select(element => int.Parse(element)).ToList());

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Execute_WithEmptyList()
        {
            Assert.Equal(0, new CountElementsArrRecursion().Execute(new List<int>()));
        }
    }
}
