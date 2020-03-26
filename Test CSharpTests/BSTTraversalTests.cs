using Xunit;
using System.Collections.Generic;

namespace Test_CSharp.Tests
{
    public class BSTTraversalTests
    {
        [Fact]
        public void TestInorderIterativeNullRoot_ReturnsEmptyList()
        {
            TreeNode nullTreeNode = null;

            List<int> emptyList = BST.InorderIterativeTraversal(nullTreeNode);

            Assert.Empty(emptyList);
        }

        [Fact]
        public void TestInorderRecursiveNullRoot_ReturnsEmptyList()
        {
            TreeNode nullTreeNode = null;

            List<int> emptyList = BST.InorderRecursiveTraversal(nullTreeNode);

            Assert.Empty(emptyList);
        }

        [Fact]
        public void TestInorderIterative_ReturnsCorrectOrder()
        {
            TreeNode left = new TreeNode(1);
            TreeNode right = new TreeNode(3);
            TreeNode root = new TreeNode(2, left, right);
            List<int> expectedResult = new List<int> { 1, 2, 3 };

            List<int> result = BST.InorderIterativeTraversal(root);

            Assert.Equal(3, result.Count);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestInorderRecursive_ReturnsCorrectOrder()
        {
            TreeNode left = new TreeNode(1);
            TreeNode right = new TreeNode(3);
            TreeNode root = new TreeNode(2, left, right);
            List<int> expectedResult = new List<int> { 1, 2, 3 };

            List<int> result = BST.InorderRecursiveTraversal(root);

            Assert.Equal(3, result.Count);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestInorderIterativeLarger_ReturnsCorrectOrder()
        {
            TreeNode root = new TreeNode(7, new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(5, null, new TreeNode(6))), new TreeNode(10, new TreeNode(8, null, new TreeNode(9)), null));
            List<int> expectedResult = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> result = BST.InorderIterativeTraversal(root);

            Assert.Equal(10, result.Count);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestInorderRecusiveLarger_ReturnsCorrectOrder()
        {
            TreeNode root = new TreeNode(7, new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(5, null, new TreeNode(6))), new TreeNode(10, new TreeNode(8, null, new TreeNode(9)), null));
            List<int> expectedResult = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> result = BST.InorderRecursiveTraversal(root);

            Assert.Equal(10, result.Count);
            Assert.Equal(expectedResult, result);
        }
    }
}