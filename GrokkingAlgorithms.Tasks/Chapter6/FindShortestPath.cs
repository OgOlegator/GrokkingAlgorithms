namespace GrokkingAlgorithms.Tasks.Chapter6
{
    /// <summary>
    /// Поиск кратчайшего пути в графе. В графе перечислены ваши друзья, друзья друзейь друзья друзей друзей и т. д. в соц. сети.
    /// Необходимо найти другого человека по имени.
    /// </summary>
    public class FindShortestPath
    {
        /// <summary>
        /// Элемент в очереди
        /// </summary>
        private class QueueElement
        {
            public string Name;

            /// <summary>
            /// Очередность элемента в графе. Иначе говоря, сколько пройдено ребер графа от начального до данного элемента.
            /// </summary>
            public int GraphLevel;
        }

        private readonly Dictionary<string, List<string>> _graph;
        private readonly string _firstElement;

        public FindShortestPath(Dictionary<string, List<string>> graph, string firstElement = "you")
        {
            _graph = graph;
            _firstElement = firstElement;
        }

        public int Execute(string findName)
        {
            var verifiedGraphItems = new HashSet<string>();

            var queue = new Queue<QueueElement>();
            queue.Enqueue(new QueueElement { Name = _firstElement, GraphLevel = 0 });

            while (queue.Count > 0)
            {
                var queueElement = queue.Dequeue();

                if (verifiedGraphItems.Contains(queueElement.Name))
                    continue;

                if (queueElement.Name == findName)
                    return queueElement.GraphLevel;

                AddNextElementsFromGraphToQueue(queueElement, queue);

                verifiedGraphItems.Add(queueElement.Name);
            }

            throw new KeyNotFoundException();
        }

        /// <summary>
        /// Добавить следующие элементы графа в очередь
        /// </summary>
        /// <param name="currentQueueElement">Обработанный элемент очереди</param>
        /// <param name="queue">Изменяемая очередь</param>
        private void AddNextElementsFromGraphToQueue(QueueElement currentQueueElement, Queue<QueueElement> queue)
        {
            var nextLevel = currentQueueElement.GraphLevel + 1;

            foreach (var item in _graph[currentQueueElement.Name])
                queue.Enqueue(new QueueElement 
                { 
                    Name = item, 
                    GraphLevel = nextLevel,
                });
        }
    }
}
