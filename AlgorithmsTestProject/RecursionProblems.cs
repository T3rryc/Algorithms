
namespace AlgorithmsTestProject
{
    public static class RecursionProblems
    {
        public static int Factorial(int n)
        {
            //throw new NotImplementedException();
            // recursive function of factorial
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static int Fibonnaci(int n)
        {
            //throw new NotImplementedException();
            // recursive function of fibonacci
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonnaci(n - 1) + Fibonnaci(n - 2);
            }
        }

        public static void ReverseArray<T>(T[] array, int n = 0)
        {
            //throw new NotImplementedException();
            // recursive function of reverse array
            if (n < array.Length / 2)
            {
                T temp = array[n];
                array[n] = array[array.Length - n - 1];
                array[array.Length - n - 1] = temp;
                ReverseArray(array, n + 1);
            }
        }

        public static int Count<T>(IIterator<T> iterator)
        {
            //throw new NotImplementedException();
            // recursive function of count
            if (iterator.GetEnd().GetElement().Equals(iterator.GetElement()))
            {
                return 1;
            }
            else
            {
                return 1 + Count(iterator.GetNext());
            }
          
        }

      

        public static IIterator<T> GetLast<T>(IIterator<T> iterator)
        {
            //throw new NotImplementedException();
            // recursive function of get last
            if (iterator.GetEnd().GetElement().Equals(iterator.GetElement()))
            {
                return iterator;
            }
            else
            {
                return GetLast(iterator.GetNext());
            }
          
        }

        public static int Sum(IIterator<int> iterator)
        {
             //throw new NotImplementedException();
             // recursive function of sum
             if (iterator.GetEnd().GetElement().Equals(iterator.GetElement()))
            {
                    return iterator.GetElement();
                }
                else
            {
                    return iterator.GetElement() + Sum(iterator.GetNext());
                }

            
            
        }

       
       
        public static IList<T> Reverse<T>(IList<T> xs)
        {
            //throw new NotImplementedException();
            // recursive function of reverse
            if (xs.GetIterator().GetEnd().GetElement().Equals(xs.GetIterator().GetElement()))
            {
                return xs;
            }
            else
            {
                xs.Insert(xs.GetIterator(), xs.GetIterator().GetNext().GetElement());
                xs.Remove(xs.GetIterator().GetNext());
                return Reverse(xs);
            }
        }

        public static IEnumerable<int> MergeSort(IEnumerable<int> values)
        {
            //throw new NotImplementedException();
            // recursive function of merge sort
            if (values.Count() <= 1)
            {
                return values;
            }
            else
            {
                int mid = values.Count() / 2;
                IEnumerable<int> left = values.Take(mid);
                IEnumerable<int> right = values.Skip(mid);
                return Merge(MergeSort(left), MergeSort(right));
            }
        }

        public static IEnumerable<int> Merge(
            IEnumerable<int> xs, 
            IEnumerable<int> ys)
        {
            foreach (var x in xs)
            {
                while (ys.Any() && ys.First() < x)
                {
                    yield return ys.First();
                    ys = ys.Skip(1);
                }

                yield return x;
            }
        }
    }
}
