using System.Collections;

namespace dip
{
    public class MyQueue<T> : IMyQueue<T>, IEnumerable<T>
    {
        private readonly LinkedList<T> _queue;
        private readonly ILogger _logger;

        public MyQueue(ILogger logger)
        {
            _queue = new LinkedList<T>();
            _logger = logger;
        }

        //enqueue
        public void Queue(T value)
        {
            _queue.AddFirst(value);
            _logger.Log($"Enqueued: {value}");
        }

        public T Dequeue()
        {
            T firstElem = _queue.First();
            _queue.RemoveFirst();
            _logger.Log($"Dequeued: {firstElem}");
            return firstElem;
        }
        public T Peek()
        {
            T firstElem = _queue.First();
            _logger.Log($"Peeked: {firstElem}");
            return firstElem;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_queue).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_queue).GetEnumerator();
        }
    }
}