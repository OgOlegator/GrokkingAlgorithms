using GrokkingAlgorithms.Tasks.Chapter2;
using System.Runtime.CompilerServices;

namespace GrokkingAlgorithms.Tests.Chapter2
{
    public class SortingBySelectionTests
    {
        [Theory]
        [InlineData("1 7 8 2 4")]
        public void GetNewArrWithRemoveElement(string arrString)
        {
            var array = arrString.Split(' ').Select(element => int.Parse(element)).ToArray();

            var result = array.GetNewArrWithRemoveElement(3);

            var expected = new int[] { 1, 7, 8, 4 };

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1 7 8 2 4")]
        [InlineData("7 8 2 4")]
        [InlineData("7 8 4")]
        [InlineData("7 8")]
        [InlineData("8")]
        public void GetSmallestIndex(string arrString)
        {
            var array = arrString.Split(' ').Select(element => int.Parse(element)).ToArray();

            var result = SortingBySelection.GetSmallestIndex(array);

            Assert.Equal(array.Min(), array[result]);
        }

        [Theory]
        [InlineData("1 7 8 2 4", "1 2 4 7 8")]
        [InlineData("11 -7 0 21 -4", "-7 -4 0 11 21")]
        public void SortingBySelectionExecute(string arrString, string resultArrString)
        {
            var array = arrString.Split(' ').Select(element => int.Parse(element)).ToArray();
            var expectedResult = resultArrString.Split(' ').Select(element => int.Parse(element)).ToArray();

            var actual = SortingBySelection.Execute(array);

            Assert.Equal(expectedResult, actual);
        }
    }
}