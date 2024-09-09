namespace GrokkingAlgorithms.Tasks.Chapter8__Жадные_алгоритмы_
{
    /// <summary>
    /// Найти наименьший набор радиостанций, покрывающих заданный набор штатов
    /// </summary>
    public class FindSetRadioStations
    {
        /// <summary>
        /// Радиостанции и покрываемые ими штаты
        /// </summary>
        private readonly Dictionary<string, string[]> _radioStations;

        public FindSetRadioStations(Dictionary<string, string[]> radioStations)
        {
            _radioStations = radioStations;
        }

        public List<string> Execute(IEnumerable<string> statesNeeded)
        {
            var result = new List<string>();

            while (statesNeeded.Count() > 0)
            {
                // Наибольшее покрытие штатов радиостанцией
                var statesCovered = new List<string>();

                // Название радиостанции с наибольшим покрытием
                var bestStationName = string.Empty;

                foreach (var station in _radioStations)
                {
                    var covered = station.Value.Intersect(statesNeeded).ToList();

                    if (covered.Count() > statesCovered.Count())
                    {
                        bestStationName = station.Key;
                        statesCovered = covered;
                    }
                }

                statesNeeded = statesNeeded.Except(statesCovered);
                result.Add(bestStationName);
            }

            return result;
        }


    }
}
