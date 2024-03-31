using GrokkingAlgorithms.Tasks.Chapter7;

namespace GrokkingAlgorithms.Tests.Chapter7
{
    public class FindShortestPathWeightedGraphTests
    {
        [Theory]
        [InlineData(1, 8, "ad")]
        [InlineData(2, 60, "ab")]
        [InlineData(3, 35, "ad")]
        public void Execute(int testNumber, int expectedResult, string expectedPath)
        {
            var actualResult = new FindShortestPathWeightedGraph(GetTestDataFabric(testNumber)).Execute(out var actualPath);

            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedPath, actualPath);
        }

        Dictionary<string, Dictionary<string, int>> GetTestDataFabric(int testNumber)
        {
            if (testNumber == 1)
                return GetTestData1();
            else if(testNumber == 2) 
                return GetTestData2();
            else if(testNumber == 3)
                return GetTestData3();
            else
                throw new Exception();
        }

        Dictionary<string, Dictionary<string, int>> GetTestData1()
        {
            var graph = new Dictionary<string, Dictionary<string, int>>();
            graph["start"] = new Dictionary<string, int>();
            graph["a"] = new Dictionary<string, int>();
            graph["b"] = new Dictionary<string, int>();
            graph["c"] = new Dictionary<string, int>();
            graph["d"] = new Dictionary<string, int>();
            graph["fin"] = new Dictionary<string, int>();

            graph["start"]["a"] = 5;
            graph["start"]["b"] = 2;

            graph["a"]["c"] = 4;
            graph["a"]["d"] = 2;

            graph["b"]["a"] = 8;
            graph["b"]["c"] = 7;

            graph["c"]["d"] = 6;
            graph["c"]["fin"] = 3;

            graph["d"]["fin"] = 1;

            return graph;
        }

        Dictionary<string, Dictionary<string, int>> GetTestData2()
        {
            var graph = new Dictionary<string, Dictionary<string, int>>();
            graph["start"] = new Dictionary<string, int>();
            graph["a"] = new Dictionary<string, int>();
            graph["b"] = new Dictionary<string, int>();
            graph["c"] = new Dictionary<string, int>();
            graph["fin"] = new Dictionary<string, int>();

            graph["start"]["a"] = 10;

            graph["a"]["b"] = 20;

            graph["b"]["c"] = 1;
            graph["b"]["fin"] = 30;

            graph["c"]["a"] = 1;

            return graph;
        }

        Dictionary<string, Dictionary<string, int>> GetTestData3()
        {
            var graph = new Dictionary<string, Dictionary<string, int>>();
            graph["start"] = new Dictionary<string, int>();
            graph["a"] = new Dictionary<string, int>();
            graph["b"] = new Dictionary<string, int>();
            graph["c"] = new Dictionary<string, int>();
            graph["d"] = new Dictionary<string, int>();
            graph["fin"] = new Dictionary<string, int>();

            graph["start"]["a"] = 5;
            graph["start"]["b"] = 0;

            graph["a"]["c"] = 15;
            graph["a"]["d"] = 20;

            graph["b"]["c"] = 30;
            graph["b"]["d"] = 35;

            graph["c"]["fin"] = 20;

            graph["d"]["fin"] = 10;

            return graph;
        }
    }
}
