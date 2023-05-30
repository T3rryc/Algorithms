using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsTestProject
{
    public static class LinkedListExercises
    {
        public static int Count<T>(this IList<T> self)
        {
            return self.Enumerate().Count();
        }

        public static void Prepend<T>(this IList<T> self, T x)
        {
            self.Insert(self.GetIterator(), x);
        }

        public static IIterator<T> GetLastIterator<T>(this IList<T> self)
        {
            var iter = self.GetIterator();
            while (iter.HasValue())
                iter = iter.GetNext();
            return iter;
        }

        public static void Append<T>(this IList<T> self, T x)
        {
<<<<<<< HEAD
            //throw new NotImplementedException();
            self.Insert(self.GetIterator().GetEnd(), x);
            

=======
            self.Insert(self.GetLastIterator(), x);
>>>>>>> 0a3361e18ffb0b5490fbeb622dc3466675f8aa02
        }

        public static T GetAt<T>(this IList<T> self, int index)
        {
<<<<<<< HEAD
            //throw new NotImplementedException();
            var iter = self.GetIterator();
            for (int i = 0; i < index; i++)
            {
                iter = iter.GetNext();
            }
=======
            var i = 0; 
            var iter = self.GetIterator();
            while (iter.HasValue() && i < index)
            {
                iter = iter.GetNext();
                i += 1;
            }

>>>>>>> 0a3361e18ffb0b5490fbeb622dc3466675f8aa02
            return iter.GetElement();
        }

        public static void SetAt<T>(this IList<T> self, int index, T element)
        {
            //throw new NotImplementedException();
            var iter = self.GetIterator();
            for (int i = 0; i < index; i++)
            {
                iter = iter.GetNext();
            }
            iter.GetElement();

        }

        public static void Swap<T>(this IList<T> self, IIterator<T> a, IIterator<T> b)
        {
            throw new NotImplementedException();
        }

        public static IList<T> Reverse<T>()
        {
           throw new NotImplementedException();


        }

        public static IEnumerable<T> Enumerate<T>(this IList<T> self)
        {
            for (var iter = self.GetIterator();
                 iter.HasValue();
                 iter = iter.GetNext())
            {
                yield return iter.GetElement();
            }
        }
    }
}