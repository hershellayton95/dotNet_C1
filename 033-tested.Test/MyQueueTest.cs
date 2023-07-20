using tested;
using Xunit;

namespace tested.Test
{
    public class MyQueueTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(5)]
        public void QueueTestFillQueue(int lenght)
        {
            var myQueue = new MyQueue<int>();

            for (int i = 0; i < lenght; i++)
            {
                myQueue.Queue(i);
            }

            Assert.Equal(lenght, myQueue.Count());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(5)]
        public void DequeueTestEmptyQueue(int lenght)
        {
            var myQueue = new MyQueue<int>();

            for (int i = 0; i < lenght; i++)
            {
                myQueue.Queue(i);
            }
            for (int i = 0; i < lenght; i++)
            {
                myQueue.Dequeue();
            }

            Assert.Empty(myQueue);
        }

        [Fact]
        public void DequeueTestReturnFirstElement()
        {
            var myQueue = new MyQueue<string>();

            var someString = "some string 3";

            myQueue.Queue("some string 1");
            myQueue.Queue("some string 2");
            myQueue.Queue(someString);

            var result = myQueue.Dequeue();

            Assert.Equal(someString, result);
        }

        [Fact]
        public void DequeueTestThrowsError()
        {
            var myQueue = new MyQueue<int>();

            Action act = () => myQueue.Dequeue();

            Assert.Throws<InvalidOperationException>(act);
        }

        [Fact]
        public void PeekTestReturnFirstElement()
        {
            var myQueue = new MyQueue<string>();

            var someString = "some string";

            myQueue.Queue(someString);
            var result = myQueue.Peek();

            Assert.Equal(someString, result);
        }

        [Fact]
        public void PeekTestThrowsError()
        {
            var myQueue = new MyQueue<int>();

            Action act = () => myQueue.Peek();

            Assert.Throws<InvalidOperationException>(act);
        }
    }
}