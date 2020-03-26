namespace Test_CSharp
{
    public class Node
    {
        public int val { get; }
        public Node next { get; set; }
        public Node(int valIn)
        {
            val = valIn;
            next = null;
        }
        public Node(int valIn, Node nodeIn)
        {
            val = valIn;
            next = nodeIn;
        }
    }
}
