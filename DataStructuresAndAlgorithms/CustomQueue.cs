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
            _length = 0;
        }

        private int _length;

        public int Length {  get { return _length; } }

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
                if(_head == null)
                {
                    _head = newNode;
                    _tail = _head;
                    _length++;
                    return;
                }

                QueueItem<T> linkNode = _head;
                for(int i = 0; i < _length - 1; i++)
                {
                    linkNode = _head.Next;
                }

                _tail.Next = newNode;
                _tail = newNode;
            }

            _length++;
        }

        public T? dequeue()
        {
            if (_head == null)
            {
                return default(T);
            }

            _length--;

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
