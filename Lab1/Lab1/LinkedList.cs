using System;

namespace Lab1
{
    public class LinkedList<T> where T : IComparable
    {
        private Node<T> _headNode;
        private int _count;
        private Node<T> HeadNode
        {
            get { return _headNode; }
            set { _headNode = value; }
        }
        public LinkedList()
        {
            _headNode = null;
            _count = 0;
        }
        
        private void AddToEnd(T item)
        {
            Node<T> currentNode = _headNode;
            if (currentNode != null)
            {
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = new Node<T>(item);
            }
            else
            {
                _headNode = new Node<T>(item);
            }
            _count++;
        }
        
        
        
        public bool IsEmpty()
        {
            return _count == 0;
        }
    }
}