namespace DataStructuresAndAlgorithms
{
    public class AlgorithmsDataStructureImplementations
    {
        // Assumes the array is sorted - returns the index 
        // at which the search value is found
        public static int BinarySearch(int[] nums, int target)
        {
            var low = 0;
            var high = nums.Length - 1;

            return binary_search(nums, low, high, target);
        }


        public static int binary_search(int[] array, int low, int hi, int searchValue)
        {
            if(array.Length == 0) return -1;

            if(array.Length == 1)
            {
                if (array[0] == searchValue)
                {
                    return 0;
                }

                return -1;
            }

            if (array.Length == 2)
            {
                if (array[0] == searchValue)
                {
                    return 0;
                }

                if (array[1] == searchValue)
                {
                    return 1;
                }

                return -1;
            }

            do
            {
                var midpoint = low + (hi - low) / 2;

                var midpointValue = array[midpoint];

                if (midpointValue == searchValue)
                {
                    return midpoint;
                }
                else if (searchValue > midpointValue)
                {
                    low = midpoint + 1;
                    if (array[low] == searchValue)
                    {
                        return low;
                    }
                }
                else if (searchValue < midpointValue)
                {
                    hi = midpoint;
                }
            }
            while (low < hi);

            return -1;
        }

        public static int two_crystal_balls(bool[] A)
        {
            var jumpAmount = (int)Math.Floor(Math.Sqrt(A.Length));
            var i = jumpAmount;

            for (; i < A.Length; i += jumpAmount)
            {
                // We've found the height at which the crystal ball breaks;
                if (A[i] == true)
                {
                    break;
                }
            }

            // now go back by jumpAmount and forward to find exactly where it breaks - using the second crystal ball
            i -= jumpAmount;

            for (var j = 0; j < jumpAmount && i < A.Length; i++, j++)
            {
                // We've found the height at which the crystal ball breaks;
                if (A[i] == true)
                {
                    return i;
                }
            }

            return -1;
        }

        public static void bubble_sort(int[] A)
        {
            // For each item in the array
            for (int i = 0; i < A.Length; i++)
            {
                // Compare it with the element in front of it
                for (int j = 0; j < A.Length - 1 - i; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        //swap elements
                        var temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }
        }

        /*
         Given an array of integers arr, return true if and only if it is a valid mountain array.

         Recall that arr is a mountain array if and only if:

         arr.length >= 3
         There exists some i with 0 < i < arr.length - 1 such that:
         arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
         arr[i] > arr[i + 1] > ... > arr[arr.length - 1]

         
         [0, 2, 3, 4, 5, 2, 1, 0] - continuous incline and decline

         [0, 2, 3, 3, 5, 2, 1, 0] - incline is broken by a plateua 3, 3

         */

        public static bool ValidMountainArray(int[] arr)
        {
            if(arr.Length < 3) return false;

            // To meet the criteria the array must have an incline - ascending values
            // followed by a decling descinding values

            // Check for incline
            var inclineCount = 0;
            int i = 0;
            for (i = 0; i < arr.Length - 1;i++)
            {
                if(arr[i] < arr[i + 1])
                {
                    inclineCount++;
                }
            }

            inclineCount++;

            if (inclineCount == arr.Length)
            {
                return false;
            }

            // currently i is the top of the mountain
            var j = inclineCount;
            //j++;

            // i is last element in array
            var declneCount = 0;
            if (j == arr.Length - 1)
            {
                if (arr[j] < arr[inclineCount])
                {
                    declneCount++;
                }
            }
            
            while(j <  arr.Length - 1) 
            {
                if (arr[j] > arr[j  + 1])
                {
                    declneCount++;
                }

                j++;
            }

            declneCount++;

            return declneCount + inclineCount == arr.Length;
        }
    }
}
