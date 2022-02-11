namespace Stack
{
    public class MyNode<T>
    {
        public  T Item { get; set; }
        public MyNode<T> PreviousNode { get; set; }

        public MyNode(T item, MyNode<T> previousNode)
        {
            Item = item;
            PreviousNode = previousNode;
        }
    }
}