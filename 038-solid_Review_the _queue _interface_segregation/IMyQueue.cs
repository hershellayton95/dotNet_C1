namespace isp
{
    public interface IMyQueue<T>
    {
        public void Queue(T value);
        public T Dequeue();
        public T Peek();
    }
}
