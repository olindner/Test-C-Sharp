using System.Collections.Generic;
namespace Test_CSharp
{
    public class BST
    {
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
    }
}
