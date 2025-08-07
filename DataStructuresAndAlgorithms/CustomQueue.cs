namespace DataStructuresAndAlgorithms
{
    public class CustomQueue<T>
    {
        private QueueItem<T>? _head;
        private QueueItem<T>? _tail;

        public CustomQueue()
        {
            _head = null;
            _tail = null;
            length = 0;
        }

        public int length { get; private set; }

        public void enqueue(T value)
        {
            var newNode = new QueueItem<T>(value, null);
            if (_tail == null)
            {
                _head = newNode;
                _tail = _head;
            }
            else
            {
                // add new node to the end of the list
                _tail.Next = newNode;
                _tail = newNode;
            }

            length++;
        }

        public T? dequeue()
        {
            if (_head == null)
            {
                return default(T);
            }

            length--;

            var head = _head;
            _head = _head.Next;

            return head.Value;
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

    public class QueueItem<T>
    {
        public QueueItem(T value, QueueItem<T>? previous)
        {
            Value = value;
        }

        public T Value { get; set; }
        public QueueItem<T>? Next { get; set; }
    }
}
