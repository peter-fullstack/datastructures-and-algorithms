namespace DataStructuresAndAlgorithms.Tests
{
    using DataStructuresAndAlgorithms;
    public class HeapTests
    {
        [Fact]
        public void Test1()
        {

            var queue = new MinHeapPriorityQueue();

            queue.insert(6);
            queue.insert(10);
            queue.insert(16);
            queue.insert(20);

            Assert.Equal([6, 10, 16, 20], queue.Heap);

            queue.insert(3);
            Assert.Equal([3, 6, 16, 20, 10], queue.Heap);
        }
    }
}
