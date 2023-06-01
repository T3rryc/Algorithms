namespace AlgorithmsTestProject;

public static class ConsListProblems
{
    public static IConsList<T> InsertBefore<T>(this IConsList<T> self, 
        int index, T value)
    {
        //throw new NotImplementedException();
        if (index == 0)
            return new ConsList<T>(value, self);
        else
            return new ConsList<T>(self.Head, self.Tail.InsertBefore(index - 1, value));


       
      

    }

  

    public static IConsList<T> RemoveAt<T>(this IConsList<T> self, 
        int index)
    {
        //throw new NotImplementedException();
        if (index == 0)
            return self.Tail;
        else
            return new ConsList<T>(self.Head, self.Tail.RemoveAt(index - 1));
     
    }
}