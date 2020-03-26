using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_CSharpTests;

namespace Test_CSharp.Tests
{
    [TestClass()]
    public class ReverseSinglyLinkedListTests
    {
        [TestMethod]
        public void TestNullNodeReverse_ReturnsNullNode()
        {
            Node nullNode = null;

            Node result = ReverseSinglyLinkedList.Run(nullNode);

            Assert.IsTrue(TestHelpers.TwoSinglyLinkedListsAreTheSame(nullNode, result));
        }

        [TestMethod]
        public void TestOneNodeReverse_ReturnsSameNode()
        {
            Node single = new Node(1);

            Node result = ReverseSinglyLinkedList.Run(single);

            Assert.IsTrue(TestHelpers.TwoSinglyLinkedListsAreTheSame(single, result));
        }

        [TestMethod()]
        public void TestBasicReverse()
        {
            Node input = new Node(1, new Node(2, new Node(3)));
            Node expectedResult = new Node(3, new Node(2, new Node(1)));

            Node result = ReverseSinglyLinkedList.Run(input);

            Assert.IsTrue(TestHelpers.TwoSinglyLinkedListsAreTheSame(expectedResult, result));
        }
    }
}