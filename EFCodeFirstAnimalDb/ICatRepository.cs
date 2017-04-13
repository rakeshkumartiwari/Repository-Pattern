using System;

namespace EFCodeFirstAnimalDb
{
   public interface ICatRepository
   {
       void Add(Cat cat);
   }

    public class InMemoryCatRepository : ICatRepository
    {
        public void Add(Cat cat)
        {
            throw new NotImplementedException();
        }
    }

    public class SqlCatRepository : ICatRepository
    {
       public void Add(Cat cat)
       {
           throw new NotImplementedException();
       }
    }
}
