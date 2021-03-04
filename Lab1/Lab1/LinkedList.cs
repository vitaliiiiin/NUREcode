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

    }
}