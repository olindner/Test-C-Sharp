namespace Test_CSharp
{
    public class TreeNode
    {
        public int val { get; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
        public TreeNode(int valIn)
        {
            val = valIn;
            left = null;
            right = null;
        }
        public TreeNode(int valIn, TreeNode leftIn, TreeNode rightIn)
        {
            val = valIn;
            left = leftIn;
            right = rightIn;
        }
    }
}
