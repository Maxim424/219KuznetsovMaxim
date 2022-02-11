using System;

namespace Stack
{
    public class MyStack<T>
    {
        private MyNode<T> _lastNode;
        private int _size;

        public MyStack()
        {
            _lastNode = null;
            _size = 0;
        }

        public void Push(T item)
        {
            MyNode<T> myNode = new MyNode<T>(item, _lastNode);
            _lastNode = myNode;
            _size++;
        }

        public T Pop()
        {
            if (!IsEmpty())
            {
                T item = _lastNode.Item;
                _lastNode = _lastNode.PreviousNode;
                _size--;
                return item;
            }
            else
            {
                throw new NullReferenceException("No elements in stack");
            }
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                return _lastNode.Item;
            }
            else
            {
                throw new NullReferenceException("No elements in stack");
            }
        }

        public int Size()
        {
            return _size;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }
    }
}