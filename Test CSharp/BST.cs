using System;
using System.Collections.Generic;
namespace Test_CSharp
{
    public class BST
    {
        public static List<int> PreorderIterativeTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while(stack.Count > 0)
            {
                root = stack.Pop();
                list.Add(root.val);
                if (root.right != null) stack.Push(root.right);
                if (root.left != null) stack.Push(root.left);
            }
            return list;
        }
        public static List<int> PreorderRecursiveTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;
            list.Add(root.val);
            list.AddRange(PreorderRecursiveTraversal(root.left));
            list.AddRange(PreorderRecursiveTraversal(root.right));
            return list;
        }
        public static List<int> InorderIterativeTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count > 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                list.Add(root.val);
                root = root.right;
            }
            return list;
        }


        public static List<int> InorderRecursiveTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;
            List<int> leftList = InorderIterativeTraversal(root.left);
            list.AddRange(leftList);
            list.Add(root.val);
            List<int> rightList = InorderIterativeTraversal(root.right);
            list.AddRange(rightList);
            return list;
        }
    }
}
