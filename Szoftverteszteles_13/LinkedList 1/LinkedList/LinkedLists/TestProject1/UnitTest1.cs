using System.Collections.Generic;
using NUnit.Framework.Internal;

namespace TestProject1
{
    public class LinkedListTests
    {
        
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void CanCreateEmptyListTest()
        {
            LinkedList linkedList = new LinkedList();
        }
        [Test]
        public void AddOneElementTest()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.add(10);
            Assert.That(linkedList.First, Is.EqualTo(10));
        }

        [Test]
        public void Count_WhenEmpty_ReturnsZero()
        {
            LinkedList linkedList = new LinkedList();
            Assert.That(linkedList.Count, Is.EqualTo(0));
        }

        [Test]
        public void Count_WhenHasOneElement()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.add(10);
            Assert.That(linkedList.Count,Is.EqualTo(1));
        }

        [Test]
        public void First_WhenEmpty_ThrowsException()
        {
            LinkedList linkedList = new LinkedList();
            Assert.Throws<InvalidOperationException>(
                    () =>
                    {
                        int i = linkedList.First;
                    }
                );
        }

        [Test]
        public void Count_WhenElemetsAdded_ReturnsTwo()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.add(10);
            linkedList.add(20);
            Assert.That(linkedList.Count, Is.EqualTo(2));

        }

        [Test]
        public void Add_ShouldSetNewFirst()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.add(10);
            linkedList.add(20);
            Assert.That(linkedList.First, Is.EqualTo(20));
        }

        [Test]
        public void Add_ReturnsNewNode()
        {
            LinkedList linkedList = new LinkedList();
            LinkedList.Node node = linkedList.add(10);
            Assert.That(node.data, Is.EqualTo(10));
        }


        [Test]
        public void InsertAfter_ShouldInsertElementInMiddle()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.add(10);
            LinkedList.Node node = linkedList.add(20);

            linkedList.InsertAfter(node, 15);

            Assert.That(node.next.data, Is.EqualTo(15));
        }

        [Test]
        public void Add_WhenNotEmpty_NextIsOriginalFirst()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.add(10);

            LinkedList.Node node =  linkedList.add(20);

            Assert.That(node.next.data, Is.EqualTo(10));
        }

        [Test]
        public void RemoveFirst_ShouldRemoveFirst()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.add(10);
            linkedList.add(20);

            linkedList.RemoveFirst();

            Assert.That(linkedList.First, Is.EqualTo(10));
        }

        [Test]

        public void RemoveFirst_OnEmptyList_ShouldThrow()
        {
            LinkedList linkedList = new LinkedList();
            Assert.Throws<InvalidOperationException>(linkedList.RemoveFirst);
          
        }
    }
}