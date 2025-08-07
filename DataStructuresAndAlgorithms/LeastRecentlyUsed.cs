namespace DataStructuresAndAlgorithms
{
    public class LeastRecentlyUsed<K, V>
    {
        private int _length { get; set; }
        private int _capacity { get; set; }
        private NodeCustom<V>? _head { get; set; }
        private NodeCustom<V>? _tail { get; set; }

        private Dictionary<K, NodeCustom<V>> _lookup;
        private Dictionary<NodeCustom<V>, K> _reverseLookup;

        public LeastRecentlyUsed(int capacity = 10)
        {
            _capacity = capacity;
            _length = 0;
            _head = null;
            _tail = null;
            _lookup = new Dictionary<K, NodeCustom<V>>();
            _reverseLookup = new Dictionary<NodeCustom<V>, K>();
        }

        public NodeCustom<V>? Get(K key)
        {
            // Check for existence
            var node = _lookup[key];

            // Update value found and move it to the front
            DetachNode(node);
            PrependNode(node);

            return node;
        }
        public void UpdateNode(K key, V value)
        {
            var node = _lookup[key];

            if (node == null)
            {
                node = CreateNode(value);

                _length++;
                PrependNode(node);
                TrimCache();

                _lookup.Add(key, node);
                _reverseLookup.Add(node, key);
            }
            else
            {
                // Does exist
                DetachNode(node);
                PrependNode(node);
                node.Value = value;
            }

        }

        private void TrimCache()
        {
            if(_length <= _capacity)
            {
                return;
            }

            var tail = _tail;

            if(tail == null)
            {
                return;
            }

            DetachNode(tail);

            var key = _reverseLookup[tail];
            _lookup.Remove(key);
            _reverseLookup.Remove(tail);
            _length--;
        }

        private NodeCustom<V> CreateNode(V value)
        {
            return new NodeCustom<V>(value, null, null);
        }

        private void DetachNode(NodeCustom<V> node)
        {
            if (node.Previous != null)
            {
                node.Previous.Next = node.Next;
            }

            if (node.Next != null)
            {
                node.Next.Previous = node.Previous;
            }

            if(_head == node)
            {
                _head = _head.Next;
            }

            if (_tail == node)
            {
                _tail = _tail.Previous;
            }

            node.Next = null;
            node.Previous = null;
        }

        private void PrependNode(NodeCustom<V> node)
        {
            if(_head == null)
            {
                _head = _tail = node;
                return;
            }

            node.Next = _head;
            _head.Previous = node;
            _head = node;
        }
    }
}
