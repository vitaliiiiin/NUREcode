using System;
using System.Collections;

namespace Lab1
{
    public class LinkedList<T> : IComparer
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

        int IComparer.Compare(object a, object b)
        {
            if (a.GetHashCode() > b.GetHashCode())
                return 1;
            
            if (a.GetHashCode() < b.GetHashCode())
                return -1;
            
            return 0;
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
            
            if (((IComparer) this).Compare(_headNode.Data, item) > 0) // in case all nodes are larger than the item to add
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
                if (currentNode.Next != null && ((IComparer) this).Compare(item, currentNode.Next.Data) < 0)
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
        
        public bool DeleteItem(T item)
        {
            // check if a list is empty
            if (IsEmpty()) return false;
            
            // checking if 1st element fits for deleting
            if (((IComparer) this).Compare(HeadNode.Data, item) == 0)
            {
                HeadNode = HeadNode.Next;
                _count--;
                
                return true;
            }
            
            // checking all the others elements
            Node<T> currentNode = _headNode;
            while (currentNode.Next.Next != null)
            {
                if (((IComparer) this).Compare(currentNode.Next.Data, item) == 0)
                {
                    currentNode.Next = new Node<T>(currentNode.Next.Next);
                    _count--;
                    
                    return true;
                }
                currentNode = currentNode.Next;
            }
            
            // checking if the last node is to delete and if so delete it
            if (((IComparer) this).Compare(currentNode.Next.Data, item) == 0)
            {
                currentNode.Next = null;
                _count--;

                return true;
            }
            
            return false;
        }
        
        public int Search(T item)
        {
            int position = 0;

            Node<T> currentNode = _headNode;
            while (currentNode != null)
            {
                if (((IComparer) this).Compare(currentNode.Data, item) == 0)
                {
                    return position;
                }
                position++;
                currentNode = currentNode.Next;
            }
            return -1;
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
        
        public int ListSize()
        {
            return _count;
        }
        
        public LinkedList<T> Difference(LinkedList<T> list2)
        {
            Node<T> currentNode = _headNode;

            LinkedList<T> differenceList = new LinkedList<T>();

            while (currentNode != null)
            {
                if (list2.Search(currentNode.Data) == -1)
                {
                    differenceList.AddItem(currentNode.Data);
                }

                currentNode = currentNode.Next;
            }
            return differenceList;
        }
    }
}