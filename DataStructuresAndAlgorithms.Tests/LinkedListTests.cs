namespace DataStructuresAndAlgorithms.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void Test1()
        {
            var linkedList = new LinkedListCustom<string>();
            
            linkedList.prepend("Fourth Node");
            linkedList.prepend("Third Node");
            linkedList.prepend("Second Node");
            linkedList.prepend("First Node");

            var firstNode = linkedList.getValue(0);
            Assert.NotNull(firstNode);
            Assert.Equal("First Node", firstNode.Value);

            var secondNode = linkedList.getValue(1);
            Assert.NotNull(secondNode);
            Assert.Equal("Second Node", secondNode.Value);

            var thirdNode = linkedList.getValue(2);
            Assert.NotNull(thirdNode);
            Assert.Equal("Third Node", thirdNode.Value);

            var fourthNode = linkedList.getValue(3);
            Assert.NotNull(fourthNode);
            Assert.Equal("Fourth Node", fourthNode.Value);
        }

        [Fact]
        public void Test2()
        {
            var linkedList = new LinkedListCustom<string>();

            linkedList.prepend("Fourth Node");
            linkedList.prepend("Third Node");
            linkedList.prepend("Second Node");
            linkedList.prepend("First Node");

            linkedList.insertAt("Inserted node", 2);

            var insertedNode = linkedList.getValue(2);
            Assert.NotNull(insertedNode);
            Assert.Equal("Inserted node", insertedNode.Value);
        }
    }
}
