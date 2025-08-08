namespace DataStructuresAndAlgorithms.Tests
{
    using DataStructuresAndAlgorithms;
    public class BubbleSortTests
    {
        [Fact]
        public void Test1()
        {
            int[] unsortedData = [2, 1];
            AlgorithmsDataStructureImplementations.bubble_sort(unsortedData);

            Assert.Equal([1, 2], unsortedData);
        }

        [Fact]
        public void Test2()
        {
            int[] unsortedData = [8, 7, 3, 11, 2]; 
            AlgorithmsDataStructureImplementations.bubble_sort(unsortedData);

            Assert.Equal([2, 3, 7, 8, 11], unsortedData);
        }
    }
}
