using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_CSharp.Tests
{
    [TestClass()]
    public class BSTTraversalTests
    {
        [TestMethod()]
        public void TestInorderIterativeNullRoot_ReturnsEmptyList()
        {
            TreeNode nullTreeNode = null;

            List<int> emptyList = BST.InorderIterativeTraversal(nullTreeNode);

            Assert.AreEqual(0, emptyList.Count);
        }

        [TestMethod]
        public void TestInorderIterative_ReturnsCorrectOrder()
        {
            TreeNode left = new TreeNode(1);
            TreeNode right = new TreeNode(3);
            TreeNode root = new TreeNode(2, left, right);
            List<int> expectedResult = new List<int> { 1, 2, 3 };

            List<int> result = BST.InorderIterativeTraversal(root);

            Assert.AreEqual(3, result.Count);
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}