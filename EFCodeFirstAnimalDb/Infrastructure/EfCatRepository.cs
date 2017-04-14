using System.Collections.Generic;
using System.Linq;
using EFCodeFirstAnimalDb.Domain;
using EFCodeFirstAnimalDb.Interface;

namespace EFCodeFirstAnimalDb.Infrastructure
{
    public class EfCatRepository : ICatRepository
    {
        readonly AnimalDB _db = new AnimalDB();
        public void Add(Cat cat)
        {
            _db.Cats.Add(cat);
            _db.SaveChanges();
        }

        public List<Cat> GetAllCats()
        {
            return _db.Cats.ToList();
        }

        public Cat GetCatById(string id)
        {
            Cat cat = _db.Cats.Single(c => c.Id == id);
            return cat;
        }
        public List<Cat> GetCatByName(string name)
        {
            List<Cat> cat = _db.Cats.Where(c => c.Name == name).ToList();
            return cat;
        }
        public void Update(Cat cat)
        {
            Cat fetchedCat = GetCatById(cat.Id);
            fetchedCat.Name = cat.Name;
            fetchedCat.Color = cat.Color;
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var fetchedCat = _db.Cats.SingleOrDefault(c => c.Id == id);
            _db.Cats.Remove(fetchedCat);
            _db.SaveChanges();
        }
    }
}