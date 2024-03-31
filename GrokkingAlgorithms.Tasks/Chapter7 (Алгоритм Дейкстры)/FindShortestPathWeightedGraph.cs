using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Tasks.Chapter7
{
    /// <summary>
    /// Найти кротчайший путь из точки A в точку B используя Алгоритм Дейкстры
    /// </summary>
    public class FindShortestPathWeightedGraph
    {
        Dictionary<string, Dictionary<string, int>> _graph;
        string _startNode;
        string _endNode;

        /// <summary>
        /// Стоимость кратчайшего пути до узла
        /// </summary>
        Dictionary<string, int> _costs = new Dictionary<string, int>();

        /// <summary>
        /// Иерархия узлов по кратчайшему пути до узла
        /// </summary>
        Dictionary<string, string> _parents = new Dictionary<string, string>();

        /// <summary>
        /// Обработанные узлы
        /// </summary>
        List<string> _processedNodes = new List<string>();

        public FindShortestPathWeightedGraph(Dictionary<string, Dictionary<string, int>> graph, string startNode = "start", string endNode = "fin")
        {
            _graph = graph;

            _startNode = startNode;
            _endNode = endNode;

            foreach(var node in _graph[startNode])
            {
                _costs[node.Key] = node.Value;
                _parents[node.Key] = startNode;
            }
        }

        public int Execute(out string resultPath)
        {
            while(TryGetNodeWithLowestWeight(out var node))
            {
                var cost = _costs[node];

                foreach(var neighbour in _graph[node])
                {
                    var newCost = cost + neighbour.Value;
                    
                    if(!_costs.TryGetValue(neighbour.Key, out var neighbourCurrentCost) || neighbourCurrentCost > newCost)
                    {
                        _costs[neighbour.Key] = newCost;
                        _parents[neighbour.Key] = node;
                    }
                }

                _processedNodes.Add(node);
            }

            resultPath = GetPathToNode(_endNode);
            return _costs[_endNode];
        }

        /// <summary>
        /// Проверить наличие и получить не обработанный узел графа с минимальным значением веса (стоимости пути)
        /// </summary>
        /// <param name="minCostNode"></param>
        /// <returns></returns>
        private bool TryGetNodeWithLowestWeight(out string minCostNode)
        {
            var minCostValue = int.MaxValue;    //В книге использовалась бесконечность для сравнения, но для упрощения использую вместо float -> int
            minCostNode = string.Empty;

            foreach (var cost in _costs)
                if (cost.Value < minCostValue && !_processedNodes.Contains(cost.Key))
                {
                    minCostValue = cost.Value;
                    minCostNode = cost.Key;
                }

            return !string.IsNullOrEmpty(minCostNode);
        }

        /// <summary>
        /// Получить кратчайший путь к узлу по точкам графа от стартового узла
        /// </summary>
        /// <param name="node">Имя узла</param>
        /// <returns>Строка с путем, которая не включает искомую точку и . Например: "acd"</returns>
        private string GetPathToNode(string node)
        {
            var parent = _parents[node];

            if(parent == _startNode)
                return string.Empty;

            return $"{GetPathToNode(parent)}{parent}";
        }
    }
}
