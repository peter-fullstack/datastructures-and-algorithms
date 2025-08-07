namespace DataStructuresAndAlgorithms
{
    public class AlgorithmsDataStructureImplementations
    {
        // Assumes the array is sorted
        public static int binary_search(int[] array, int low, int hi, int searchValue)
        {
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
    }
}
