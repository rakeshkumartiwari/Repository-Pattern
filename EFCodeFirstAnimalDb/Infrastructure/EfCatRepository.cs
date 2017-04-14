using System.Collections.Generic;
using System.Linq;
using EFCodeFirstAnimalDb.Domain;

namespace EFCodeFirstAnimalDb.Infrastructure
{
    public class EfCatRepository : ICatRepository
    {
        AnimalDB db = new AnimalDB();
        public void Add(Cat cat)
        {
            db.Cats.Add(cat);
            db.SaveChanges();
        }

        public List<Cat> GetAllCats()
        {
            return db.Cats.ToList();
        }

        public Cat GetCatById(string id)
        {
            Cat cat = db.Cats.Single(c => c.Id == id);
            return cat;
        }
        public void Update(Cat cat)
        {
            Cat fetchedCat = GetCatById(cat.Id);
            fetchedCat.Name = cat.Name;
            fetchedCat.Color = cat.Color;
            db.SaveChanges();
        }
    }
}