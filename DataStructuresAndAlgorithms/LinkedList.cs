namespace DataStructuresAndAlgorithms
{
    public class LinkedList
    {
    }

    public class LinkedListCustom<T>: ILinkedList<T> where T : class
    {
        private NodeCustom<T>? _listHead;
        private NodeCustom<T>? _listTail;
        private int _count;

        public LinkedListCustom() { }


        public NodeCustom<T>? getValue(int index)
        {
            if (_listHead == null)
            {
                return null;
            }

            NodeCustom<T>? currentNode = _listHead;

            for (int i = 0; i < index; i++)
            {
                if (currentNode == null)
                {
                    break;
                }

                currentNode = currentNode.Next;
            }

            return currentNode;
        }

        public void insertAt(T newNodeValue, int index)
        {
            if (index < 0)
            {
                throw new Exception($"Insert must be greater than or equal to zero");
            }

            if (index > _count)
            {
                throw new Exception($"Insert at index must be {_count} or less");
            }
            else if (index == _count)
            {
                append(newNodeValue);
            }
            else if (index == 0)
            {
                prepend(newNodeValue);
            }


            var nodeToInsertAt = getValue(index);

            if (nodeToInsertAt == null)
            {
                throw new Exception($"No node fount at index {index}");
            }

            var newNode = new NodeCustom<T>(newNodeValue, null, null);

            var previousNode = nodeToInsertAt.Previous;

            // 1. newNodes Previous is now nodeToInsertAt's previous
            newNode.Previous = previousNode;
            if (previousNode != null)
            {
                previousNode.Next = newNode;
            }

            // 2. Point nodeToInsertAt previous to newNode
            nodeToInsertAt.Previous = newNode;

            newNode.Next = nodeToInsertAt;

            _count++;
        }

        public void append(T value)
        {
            var newNode = new NodeCustom<T>(value, null, null);

            if (_listHead == null)
            {
                // First time something is added to list
                _listHead = newNode;
                _listTail = _listHead;
            }
            else
            {
                if (_listTail == null)
                {
                    throw new InvalidOperationException("List Tail cannot be null");
                }

                if (_listTail.Previous == null)
                {
                    // There is only one item in the list tail and head are the same
                    newNode.Previous = _listHead;
                    _listHead.Next = newNode;

                    _listTail = newNode;

                }
                else
                {
                    var listTailPrevious = _listTail.Previous;
                    newNode.Previous = listTailPrevious;
                    listTailPrevious.Next = newNode;
                    _listTail = newNode;
                }
            }

            _count++;
        }

        public void prepend(T value)
        {
            var newNode = new NodeCustom<T>(value, null, null);

            if (_listHead == null)
            {
                // First time something is added to list
                _listHead = newNode;
                _listTail = _listHead;
            }
            else
            {
                if (_listTail == null)
                {
                    throw new InvalidOperationException("List Tail cannot be null");
                }

                newNode.Next = _listHead;
                _listHead.Previous = newNode;
                _listHead = newNode;
            }

            _count++;
        }

        public int length()
        {
            return _count;
        }

        public T? remove(T item)
        {
            if(_count <= 0)
            {
                return default(T?);
            }

            var current = _listHead;

            for (int i = 0; current != null && i < _count; i++)
            {
                if(current.Value == item)
                {
                    break;
                }

                current = current.Next;
            }

            if(current == null)
            {
                return default(T?);
            }

            if(_count == 1)
            {
                var value = _listHead?.Value;
                _listHead = _listTail = null;
                _count--;

                return value;
            }
            else
            {
                var previous = current.Previous;
                var next = current.Next;

                if (previous != null) {
                    previous.Next = next;
                }

                if (next != null)
                {
                    next.Previous = previous;
                }

                if(current == _listHead)
                {
                    _listHead = current.Previous;
                }

                if (current == _listTail)
                {
                    _listTail = current.Previous;
                }

                current.Previous = current.Next = null;

            }
            _count--;

            
            return current.Value;
        }

        public T? removeAt(int index)
        {
            throw new NotImplementedException();
        }
    }

    public interface ILinkedList<T>
    {
        int length();
        void insertAt(T item, int index);
        T? remove(T item);
        T? removeAt(int index);
        void append(T item);
        void prepend(T item);
        NodeCustom<T>? getValue(int index);
    }

    public class NodeCustom<T>
    {
        public NodeCustom(T bob, NodeCustom<T>? previous, NodeCustom<T>? next)
        {
            Value = bob;
            Previous = previous;
            Next = next;
        }

        public T Value { get; set; }
        public NodeCustom<T>? Next { get; set; }
        public NodeCustom<T>? Previous { get; set; }
    }
}
