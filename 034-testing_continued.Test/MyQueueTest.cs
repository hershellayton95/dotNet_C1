using tested;

namespace _034_testing_continued.Test
{
    public class MyQueueTest
    {
        private MyQueue<int> _myQueue;

        public MyQueueTest()
        {
            _myQueue = new MyQueue<int>();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(5)]
        public void QueueTestFillQueue(int lenght)
        {

            for (int i = 0; i < lenght; i++)
            {
                _myQueue.Queue(i);
            }

            Assert.Equal(lenght, _myQueue.Count());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(5)]
        public void DequeueTestEmptyQueue(int lenght)
        {

            for (int i = 0; i < lenght; i++)
            {
                _myQueue.Queue(i);
            }
            for (int i = 0; i < lenght; i++)
            {
                _myQueue.Dequeue();
            }

            Assert.Empty(_myQueue);
        }

        [Fact]
        public void DequeueTestReturnFirstElement()
        {

            var number = 1;

            _myQueue.Queue(3);
            _myQueue.Queue(2);
            _myQueue.Queue(number);
            var result = _myQueue.Dequeue();

            Assert.Equal(number, result);
        }

        [Fact]
        public void DequeueTestThrowsError()
        {

            void act() => _myQueue.Dequeue();

            Assert.Throws<InvalidOperationException>(act);
        }

        [Fact]
        public void PeekTestReturnFirstElement()
        {

            var number = 1;

            _myQueue.Queue(number);
            var result = _myQueue.Peek();

            Assert.Equal(number, result);
        }

        [Fact]
        public void PeekTestThrowsError()
        {

            void act() => _myQueue.Peek();

            Assert.Throws<InvalidOperationException>(act);
        }
    }
}