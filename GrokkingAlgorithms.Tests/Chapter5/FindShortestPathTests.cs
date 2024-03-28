using GrokkingAlgorithms.Tasks.Chapter5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tests.Chapter5
{
    public class FindShortestPathTests
    {
        [Theory]
        [InlineData("anuj", 2)]
        [InlineData("peggy", 2)]
        [InlineData("bob", 1)]
        [InlineData("oleg", 3)]
        [InlineData("you", 0)]
        [InlineData("nastya", 4)]
        public void Execute(string findName, int expectedCountSteps)
        {
            var actual = new FindShortestPath(GetGraph(), "you").Execute(findName);

            Assert.Equal(expectedCountSteps, actual);
        }

        [Fact]
        public void Execute_SearchNameNotInGraph_Fail()
        {
            try
            {
                var actual = new FindShortestPath(GetGraph(), "you").Execute("sasha");
                Assert.True(false);
            }
            catch (KeyNotFoundException)
            {
                Assert.True(true);
            }
        }

        private Dictionary<string, List<string>> GetGraph()
        {
            var graphDict = new Dictionary<string, List<string>>();

            graphDict["you"] = ["bob", "claire", "alice"];
            graphDict["bob"] = ["anuj", "peggy"];
            graphDict["claire"] = ["thom", "jonny"];
            graphDict["alice"] = ["peggy"];
            graphDict["peggy"] = ["oleg"];
            graphDict["oleg"] = ["nastya"];
            graphDict["nastya"] = [];
            graphDict["thom"] = [];
            graphDict["jonny"] = [];
            graphDict["anuj"] = [];

            return graphDict;
        }
    }
}
