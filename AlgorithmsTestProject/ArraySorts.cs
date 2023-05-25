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
<<<<<<< HEAD
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

=======
            var current = array.ToList();
            var result = new List<int>();
            while (current.Count > 0)
            {
                var x = current.Min();
                result.Add(x);
                current.Remove(x);
            }
            result.CopyTo(array);
>>>>>>> 1df71084b17dc8510368213545569bf37ece0e9c
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
            throw new NotImplementedException();
            

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

            




              
        }
     
          

        public static void BlockSort(int[] array)
        {
            //throw new NotImplementedException();
            var n = array.Length;
            var max = array[0];
            var min = array[0];
            for (var i = 1; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            var range = max - min + 1;
            var count = new int[range];
            for (var i = 0; i < n; i++)
            {
                count[array[i] - min]++;
            }
            for (var i = 1; i < range; i++)
            {
                count[i] += count[i - 1];
            }
            var output = new int[n];
            for (var i = n - 1; i >= 0; i--)
            {
                output[count[array[i] - min] - 1] = array[i];
                count[array[i] - min]--;
            }
            for (var i = 0; i < n; i++)
            {
                array[i] = output[i];
            }

        }

        public static void BogoSort(int[] array)
        {
            //throw new NotImplementedException();
            var n = array.Length;
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
            throw new NotImplementedException();
        }

        public static void SelectionSort(int[] array)
        {
        }
    }
}
