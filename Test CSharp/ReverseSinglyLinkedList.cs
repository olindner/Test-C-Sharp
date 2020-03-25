namespace Test_CSharp
{
    public class ReverseSinglyLinkedList
    {
        public static Node Run(Node root)
        {
            if (root == null) return root;
            Node first = null, second = root, third = null;
            while(second != null)
            {
                third = second.next;
                second.next = first;
                first = second;
                second = third;
            }
            return first;
        }
    }
}
