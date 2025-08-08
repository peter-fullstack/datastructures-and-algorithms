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
    }
}
