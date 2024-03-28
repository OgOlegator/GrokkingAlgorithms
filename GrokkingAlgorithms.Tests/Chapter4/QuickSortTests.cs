using GrokkingAlgorithms.Tasks.Chapter4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tests.Chapter4
{
    public class QuickSortTests
    {
        [Theory]
        [InlineData("9 1 7 -6 0 12 5", "-6 0 1 5 7 9 12")]
        [InlineData("9", "9")]
        [InlineData("9 9 9", "9 9 9")]
        [InlineData("9 0 9 0 9", "0 0 9 9 9")]
        public void Execute(string inputArr, string expectedArr)
        {
            var actual = new QuickSort().Execute(inputArr.Split(' ').Select(int.Parse).ToList());
            var expected = expectedArr.Split(' ').Select(int.Parse).ToList();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Execute_EmptyArr() 
        {
            Assert.Equal(0, new QuickSort().Execute(new List<int>()).Count());
        }
    }
}
