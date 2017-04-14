using System;
using EFCodeFirstAnimalDb.Domain;

namespace EFCodeFirstAnimalDb.Interface
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
}
