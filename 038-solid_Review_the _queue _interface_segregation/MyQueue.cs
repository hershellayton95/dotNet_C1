using System.Collections;

namespace isp
{
    public class MyQueue<T> : IMyQueue<T>, IEnumerable<T>
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
            T firstElem = _queue.First();
            _queue.RemoveFirst();

            return firstElem;
        }
        public T Peek()
        {
            T firstElem = _queue.First();

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