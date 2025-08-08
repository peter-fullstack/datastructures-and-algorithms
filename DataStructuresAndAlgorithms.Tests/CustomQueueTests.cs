namespace DataStructuresAndAlgorithms.Tests
{
    public class CustomQueueTests
    {
        [Fact]
        public void Test1()
        {
            var queue = new CustomQueue<int>();

            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);

            // Queues are FIFO - first in first out
            Assert.Equal(3, queue.Length);
            Assert.Equal(1, queue.dequeue());
            Assert.Equal(2, queue.Length);
        }

        [Fact]
        public void Test2()
        {
            var queue = new CustomQueue<int>();

            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);

            // Queues are FIFO - first in first out
            Assert.Equal(3, queue.Length);
            Assert.Equal(1, queue.peek());
            Assert.Equal(3, queue.Length);
        }
    }
}
