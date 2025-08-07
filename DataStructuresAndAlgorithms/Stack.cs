namespace DataStructuresAndAlgorithms
{
    public class Stack<T>
    {
        private StackItem<T>? _head;


        public Stack()
        {
            _head = null;
            length = 0;
        }

        public int length { get; private set; }

        public void push(T value)
        {
            var newItem = new StackItem<T>(value);

            if (_head != null)
            {
                _head = newItem;
            }
            else
            {
                newItem.Previous = _head;
                _head = newItem;
            }

            length++;
        }

        public T? pop()
        {
            length--;

            if (length <= 0)
            {
                var head = _head;
                _head = null;
                if (head != null)
                {
                    return head.Value;
                }

                return default(T);
            }
            else
            {
                var head = _head;
                _head = head?.Previous;
                if (head != null)
                {
                    return head.Value;
                }

                return default(T);
            }
        }

        public T? peek()
        {
            if (_head != null)
            {
                return _head.Value;
            }

            return default(T);
        }
    }

    public class StackItem<T>
    {
        public StackItem(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public StackItem<T>? Previous { get; set; }
    }
}
