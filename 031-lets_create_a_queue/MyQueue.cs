using System.Collections;

namespace _031_lets_create_a_queue
{
    public class MyQueue<T> : IEnumerable<T>
    {
        private readonly LinkedList<T> _queue;

        public MyQueue()
        {
            _queue = new LinkedList<T>();
        }

        //enqueue
        public void Queue(T value)
        {
            _queue.AddFirst(value);
        }

        public T Dequeue()
        {
            T firstElem = _queue.Last();
            _queue.RemoveLast();
            return firstElem;
        }

        public T Peek()
        {
            T firstElem = _queue.Last();
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
