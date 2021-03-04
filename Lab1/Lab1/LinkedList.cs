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
        
        public void AddItem(T item)
        {
            if (IsEmpty()) // in case a list is empty
            {
                AddToEnd(item);
                return;
            }
            
            if (_headNode.Data.CompareTo(item) > 0) // in case all nodes are larger than the item to add
            {
                _headNode = new Node<T>(item)
                {
                    Next = _headNode
                };
                _count++;
                return;
            }
            
            Node<T> currentNode = _headNode;

            while (currentNode != null) // here we are looking for a place to add a new node and add it
            {
                if (currentNode.Next != null && item.CompareTo(currentNode.Next.Data) < 0)
                {
                    Node<T> nodeToAdd = new Node<T>(item);
                    nodeToAdd.Next = currentNode.Next;
                    currentNode.Next = nodeToAdd;
                    _count++;
                    return;
                }

                if (currentNode.Next == null)
                {
                    AddToEnd(item);
                    return;
                }
                currentNode = currentNode.Next;
            }
        }
        
        public void PrintList()
        {
            Node<T> currentNode = HeadNode;

            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.Next;
            }
        }
        
        public bool IsEmpty()
        {
            return _count == 0;
        }
    }
}