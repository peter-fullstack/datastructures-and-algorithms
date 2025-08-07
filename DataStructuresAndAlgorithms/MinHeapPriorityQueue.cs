using System.Collections;

namespace DataStructuresAndAlgorithms
{
    /*
     A binary tree where every child and grand child is smaller (MaxHeap) or larger (MinHeap) 
     than the current node.


     MinHeap - top value must be smallest:
     Heaps maintain weak ordering 

                 50
            71      100
         101  80  200  101

     MinHeap condition - every item must be larger than the root
     MaxHeap condition - every item must be smaller than the root

     Use an array to represent the tree - parent at index i has children at indexes 
     
     2i + 1 and 2i + 2

     */
    public class MinHeapPriorityQueue
    {
        public int Length {  get; private set; }

        private List<int> _heap;

        public MinHeapPriorityQueue()
        {
            _heap = new List<int>();
            Length = 0;
        }

        public List<int> Heap { get { return _heap; } }

        public void insert(int i)
        {
            _heap.Add(i);
            HeapifyUp(Length);
            Length++;
        }

        public int delete()
        {
            if(_heap.Count == 0)
            {
                return -1;
            }

            var deletedValue = _heap[0];
            if (_heap.Count == 1)
            {
                
                _heap.Clear();
                Length = 0;
                return deletedValue;
            }

            Length--;
            _heap[0] = _heap[Length];

            HeapifyDown(0);

            return deletedValue;
        }

        private int parent(int index)
        {
            return (int)Math.Floor((decimal)((index - 1) / 2));
        }

        private int leftChild(int index)
        {
            return (index * 2) + 1;
        }

        private int rightChild(int index)
        {
            return (index * 2) + 2;
        }

        private void HeapifyUp(int index)
        {
            if(index == 0)
            {
                return;
            }

            var parentIndex = this.parent(index); 
            var parentValue = this._heap[parentIndex];
            
            var childValue = this._heap[index];
            
            if(parentValue >  childValue)
            {
                _heap[index] = parentValue;
                _heap[parentIndex] = childValue;

                this.HeapifyUp(parentIndex);
                
            }
        }

        private void HeapifyDown(int index)
        {
            if (index >= _heap.Count())
            {
                return;
            }

            var leftChildIndex = this.leftChild(index);
            var rightChildIndex = this.rightChild(index);

          
            if (leftChildIndex >= _heap.Count())
            {
                return;
            }

            var parentValue = this._heap[index];

            var leftChildValue = this._heap[leftChildIndex];
            var rightChildValue = this._heap[rightChildIndex];

            if(leftChildValue > rightChildValue && parentValue > rightChildValue)
            {
                _heap[index] = rightChildValue;
                _heap[rightChildIndex] = parentValue;
                this.HeapifyUp(rightChildIndex);
            }
            else if (rightChildValue > leftChildValue && parentValue > leftChildValue)
            {
                _heap[index] = leftChildValue;
                _heap[leftChildIndex] = parentValue;
                this.HeapifyUp(leftChildIndex);
            }
        }
    }
}
