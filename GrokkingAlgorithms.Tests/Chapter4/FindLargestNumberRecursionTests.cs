using GrokkingAlgorithms.Tasks.Chapter4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tests.Chapter4
{
    public class FindLargestNumberRecursionTests
    {
        [Theory]
        [InlineData("5", 5)]
        [InlineData("5 102 -45 99", 102)]
        public void Excecute(string numbersArr, int expected)
        {
            var numbers = numbersArr.Split().Select(x => int.Parse(x)).ToList();

            Assert.Equal(expected, new FindLargestNumberRecursion().Execute(numbers));
        }

        [Fact]
        public void ExcecuteWithEmptyList_ThrowEx() 
        {
            try
            {
                new FindLargestNumberRecursion().Execute(new List<int>());
                
                Assert.False(true);
            }
            catch (ArgumentException)
            {
                Assert.True(true);
            }
        }
    }
}
