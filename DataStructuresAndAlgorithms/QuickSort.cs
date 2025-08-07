using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class QuickSort
    {
        public void Sort(int[] data) {
            
            SortPartition(data, 0, data.Length  - 1 );
        }

        public void SortPartition(int[] arr, int low, int high)
        {
            if(low >= high)
            {
                return;
            }

            var pivotIndex = Partition(arr, low, high);

            SortPartition(arr, low, pivotIndex - 1);
            SortPartition(arr, pivotIndex + 1, high);
        }

        public int Partition(int[] arr, int low, int high)
        {
            var pivot = arr[high];

            var idx = low -1;

            for (int i = low; i < high; i++)
            {
                if (arr[i] < pivot)
                {
                    idx++;
                    var temp = arr[i];
                    arr[i] = arr[idx];
                    arr[idx] = temp;
                }
            }

            idx++;
            arr[high] = arr[idx];
            arr[idx] = pivot;

            return idx;
        }
    }


}
