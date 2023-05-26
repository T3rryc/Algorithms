namespace AlgorithmsTestProject
{
    public static class ArraySortProblems
    {
        public static void MySort1(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        ArrayProblems.Swap(array, i, j);
                    }
                }
            }
        }

        public static void MySort2(int[] array)
        {

           // insertion sort
            for (var i = 1; i < array.Length; i++)
            {
                var j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    ArrayProblems.Swap(array, j, j - 1);
                    j--;
                }
            }


            var current = array.ToList();
            var result = new List<int>();
            while (current.Count > 0)
            {
                var x = current.Min();
                result.Add(x);
                current.Remove(x);
            }
            result.CopyTo(array);

        }

        public static void MergeSort(int[] array)
        {
            //throw new NotImplementedException();
            if (array.Length < 2)
            {
                return;
            }
            var mid = array.Length / 2;
            var left = new int[mid];
            var right = new int[array.Length - mid];
            for (var i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }
            for (var i = mid; i < array.Length; i++)
            {
                right[i - mid] = array[i];
            }
            MergeSort(left);
            MergeSort(right);
            Merge(array, left, right);

           
              

            

        }

        public static void Merge(int[] array, int[] left, int[] right)
        {
            var i = 0;
            var j = 0;
            var k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                    k++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                    k++;
                }
            }
            while (i < left.Length)
            {
                array[k] = left[i];
                i++;
                k++;
            }
            while (j < right.Length)
            {
                array[k] = right[j];
                j++;
                k++;
            }
        }

        public static void HeapSort(int[] array)
        {
            //throw new NotImplementedException();
            BuildHeap(array);
            for (var i = array.Length - 1; i >= 1; i--)
            {
                ArrayProblems.Swap(array, 0, i);
                Heapify(array, i, 0);
            }

        }
        public static void BuildHeap(int[] array)
        {
            for (var i = array.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(array, array.Length, i);
            }
        }

        public static void Heapify(int[] array, int n, int i)
        {
            var largest = i;
            var left = 2 * i + 1;
            var right = 2 * i + 2;
            if (left < n && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < n && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                ArrayProblems.Swap(array, i, largest);
                Heapify(array, n, largest);
            }
        }

        public static void BubbleSort(int[] array)
        {
            bool swapped;
            var n = array.Length;
            do
            {
                swapped = false;

                for (var i = 1; i < n; ++i)
                {
                    if (array[i - 1] > array[i])
                    {
                        ArrayProblems.Swap(array, i-1, i);
                        swapped = true;
                    }
                }

                --n;
            } 
            while (swapped && n > 0);
        }

        public static void ShuffleSort(int[] array)
        {
            //throw new NotImplementedException();
            // cocktail shatter sort
            var i = 0;
            var j = array.Length - 1;
            while (i < j)
            {
                if (array[i] > array[i + 1])
               {
                    ArrayProblems.Swap(array, i, i + 1);
               }
               i++;
                if (array[j] < array[j - 1])
               {
                   ArrayProblems.Swap(array, j, j - 1);
                }
               j--;
            }
        }

        public static void IntroSort(int[] array)
        {
            //throw new NotImplementedException();
            Array.Sort(array);



        }
         
       
        

        public static void CocktailSort(int[] array)
        {
            //throw new NotImplementedException();
            var swapped = false;
            var n = array.Length;
            do
            {
                for (var i = 1; i < n; ++i)
                {
                    if (array[i - 1] > array[i])
                    {
                        ArrayProblems.Swap(array, i - 1, i);
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
                swapped = false;
                --n;
                for (var i = n - 1; i > 0; --i)
                {
                    if (array[i - 1] > array[i])
                    {
                        ArrayProblems.Swap(array, i - 1, i);
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        public static void QuickSort(int[] array)
        {
            //throw new NotImplementedException();
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);

            return i + 1;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }




        public static void BlockSort(int[] array)
        {
            //throw new NotImplementedException();
            int blockSize = (int)Math.Sqrt(array.Length);

            // Sort each block
            for (int i = 0; i < array.Length; i += blockSize)
            {
                int endIndex = Math.Min(i + blockSize - 1, array.Length - 1);
                SortBlock(array, i, endIndex);
            }

            // Merge sorted blocks
            int mergeSize = blockSize;
            while (mergeSize < array.Length)
            {
                for (int i = 0; i < array.Length; i += mergeSize * 2)
                {
                    int mid = Math.Min(i + mergeSize - 1, array.Length - 1);
                    int end = Math.Min(i + mergeSize * 2 - 1, array.Length - 1);
                    MergeBlocks(array, i, mid, end);
                }
                mergeSize *= 2;
            }
        }
        private static void SortBlock(int[] arr, int start, int end)
        {
            Array.Sort(arr, start, end - start + 1);
        }
        private static void MergeBlocks(int[] arr, int start, int mid, int end)
        {
            int[] merged = new int[end - start + 1];
            int i = start;
            int j = mid + 1;
            int k = 0;

            while (i <= mid && j <= end)
            {
                if (arr[i] <= arr[j])
                    merged[k++] = arr[i++];
                else
                    merged[k++] = arr[j++];
            }

            while (i <= mid)
                merged[k++] = arr[i++];

            while (j <= end)
                merged[k++] = arr[j++];

            Array.Copy(merged, 0, arr, start, merged.Length);
        }



        public static void BogoSort(int[] array)
        {
            //throw new NotImplementedException();
            
            while (!IsSorted(array))
            {
                Shuffle(array);
            }

        }
            public static bool IsSorted(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }
            return true;
            }

        public static void Shuffle(int[] array)
        {
            var n = array.Length;
            for (var i = 0; i < n; i++)
            {
                var r = i + (int)(new Random().NextDouble() * (n - i));
                ArrayProblems.Swap(array, r, i);
            }
        }
       


        public static void DoNothingSort(int[] array)
        {

        }

        public static void EvilSort(int[] array)
        {
            Array.Fill(array, 0);
        }

        public static void GnomeSort(int[] array)
        {
            //throw new NotImplementedException();
            var i = 1;
            var j = 2;
            while (i < array.Length)
            {
                if (array[i - 1] <= array[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    ArrayProblems.Swap(array, i - 1, i);
                    i--;
                    if (i == 0)
                    {
                        i = j;
                        j++;
                    }
                }
            }


        }

        public static void SelectionSort(int[] array)
        {
            //throw new NotImplementedException();
            var n = array.Length;
            for (var i = 0; i < n - 1; i++)
            {
                var min = i;
                for (var j = i + 1; j < n; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                ArrayProblems.Swap(array, min, i);
            }
        }
    }
}
