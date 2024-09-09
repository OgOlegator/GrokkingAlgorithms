using GrokkingAlgorithms.Tasks.Chapter8__Жадные_алгоритмы_;

namespace GrokkingAlgorithms.Tests.Chapter8
{
    public class FindSetRadioStationsTests
    {
        [Theory]
        [InlineData(new string[] { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" }, new string[] { "kone", "ktwo", "kthree", "kfive" })]
        [InlineData(new string[] { "fi", "fl", "tx", "id", "nv" }, new string[] { "ksix" })]
        [InlineData(new string[] { "fi", "fl", "tx", "id", "ut" }, new string[] { "ksix", "kone" })]
        public void Execute(string[] inArr, string[] outArr)
        {
            Assert.Equal(outArr.ToList(), new FindSetRadioStations(GetTestData()).Execute(inArr.ToList()));
        }

        private Dictionary<string, string[]> GetTestData()
        {
            return new Dictionary<string, string[]>
            {
                { "kone", new string[] { "id", "nv", "ut" } },
                { "ktwo", new string[] { "wa", "id", "mt" } },
                { "kthree", new string[] { "or", "nv", "ca" } },
                { "kfour", new string[] { "nv", "ut" } },
                { "kfive", new string[] { "ca", "az" } },
                { "ksix", new string[] { "fi", "fl", "tx", "id", "nv" } }
            };
        }
    }
}
