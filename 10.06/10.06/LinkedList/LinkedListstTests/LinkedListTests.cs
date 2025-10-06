namespace LinkedListsTests
{
    public class LinkedListsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanCreateEmptyListTest()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();

        }

        [Test]
        public void AddOneElement()
        {
            LinkedList.LinkedList linkedlist = new LinkedList.LinkedList();
            linkedlist.Add(10);
            Assert.That(linkedlist.First, Is.EqualTo(10));
        }
    }
}