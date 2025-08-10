namespace DataStructuresAndAlgorithms.Tests
{
    using DataStructuresAndAlgorithms;
    public class BinarySearchTests
    {
        [Fact]
        public void Test1()
        {
            int[] sortedData = [1, 4, 6, 9, 14, 23];
            var index = AlgorithmsDataStructureImplementations.binary_search(sortedData, 0, sortedData.Length -1, 6);

            Assert.Equal(2, index);
        }

        [Fact]
        public void Test2()
        {
            int[] sortedData = [1, 4, 6, 9, 14, 23];
            var index = AlgorithmsDataStructureImplementations.binary_search(sortedData, 0, sortedData.Length - 1, 3);

            Assert.Equal(-1, index);
        }

        [Fact]
        public void Test3()
        {
            int[] sortedData = [1, 4, 6, 9, 14, 23];
            var index = AlgorithmsDataStructureImplementations.BinarySearch(sortedData, 9);

            Assert.Equal(3, index);
        }

        [Fact]
        public void Test4()
        {
            int[] sortedData = [2, 5];
            var index = AlgorithmsDataStructureImplementations.BinarySearch(sortedData, 5);

            Assert.Equal(1, index);
        }


        [Fact]
        public void Test5()
        {
            int[] sortedData = [-1, 0, 5];
            var index = AlgorithmsDataStructureImplementations.BinarySearch(sortedData, 5);

            Assert.Equal(2, index);
        }

        [Fact]
        public void Test6()
        {
            int[] sortedData = [0, 2, 3, 4, 2, 1, 0];
            var result = AlgorithmsDataStructureImplementations.ValidMountainArray(sortedData);

            Assert.True(result);
        }
    }
}
