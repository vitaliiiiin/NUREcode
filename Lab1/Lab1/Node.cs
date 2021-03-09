namespace Lab1
{
    public class Node<T>
    {
        private T _data;
        public T Data
        {
            get { return _data; }
            set { _data = value; }
        }
        
        private Node<T> _next;
        public Node<T> Next
        {
            get { return _next; }
            set { _next = value; }
        }
        
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
        
        public Node(Node<T> node)
        {
            Data = node.Data;
            Next = node.Next;
        }
    }
}