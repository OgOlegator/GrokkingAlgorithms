namespace GrokkingAlgorithms.Tasks.Chapter6
{
    /// <summary>
    /// Поиск кратчайшего пути в незвешанном графе с использованием Алгоритма поиска в ширину
    /// В графе перечислены ваши друзья, друзья друзей, друзья друзей друзей и т. д. в соц. сети.
    /// Необходимо найти другого человека по имени.
    /// </summary>
    public class FindShortestPathUnweightedGraph
    {
        /// <summary>
        /// Узел графа в очереди
        /// </summary>
        class NodeInQueue
        {
            public string Name;

            /// <summary>
            /// Очередность элемента в графе. Иначе говоря, сколько пройдено ребер графа от начального до данного элемента.
            /// </summary>
            public int GraphLevel;
        }

        readonly Dictionary<string, List<string>> _graph;
        readonly string _firstNode;
        Queue<NodeInQueue> _queue;

        public FindShortestPathUnweightedGraph(Dictionary<string, List<string>> graph, string firstNode = "you")
        {
            _graph = graph;
            _firstNode = firstNode;
        }

        public int Execute(string findNode)
        {
            var verifiedGraphNodes = new HashSet<string>();

            _queue = new Queue<NodeInQueue>();
            _queue.Enqueue(new NodeInQueue { Name = _firstNode, GraphLevel = 0 });

            while (_queue.Count > 0)
            {
                var node = _queue.Dequeue();

                if (verifiedGraphNodes.Contains(node.Name))
                    continue;

                if (node.Name == findNode)
                    return node.GraphLevel;

                AddNextNodesFromGraphToQueue(node);

                verifiedGraphNodes.Add(node.Name);
            }

            throw new KeyNotFoundException();
        }

        /// <summary>
        /// Добавить следующие элементы графа в очередь
        /// </summary>
        /// <param name="node">Обработанный элемент очереди</param>
        void AddNextNodesFromGraphToQueue(NodeInQueue node)
        {
            var nextLevel = node.GraphLevel + 1;

            foreach (var item in _graph[node.Name])
                _queue.Enqueue(new NodeInQueue 
                { 
                    Name = item, 
                    GraphLevel = nextLevel,
                });
        }
    }
}
