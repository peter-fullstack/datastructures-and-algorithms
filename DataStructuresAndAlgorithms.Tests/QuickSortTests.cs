namespace DataStructuresAndAlgorithms.Tests
{
    public class QuickSortTests
    {
        [Fact]
        public void Test1()
        {
            int[] unsorted = [4, 2, 3, 1];

            var quickSort = new QuickSort();
            quickSort.Sort(unsorted);

            Assert.Equal([1, 2, 3, 4], unsorted);
        }

        [Fact]
        public void Test2()
        {

            int[] unsorted = [4, 7, 6, 2, 3, 5, 1];

            var quickSort = new QuickSort();
            quickSort.Sort(unsorted);

            Assert.Equal([1, 2, 3, 4, 5, 6, 7], unsorted);
        }
    }
}
