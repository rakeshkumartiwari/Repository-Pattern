using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCodeFirstAnimalDb
{
    public class AnimalDB : DbContext
    {
        public void Seed(AnimalDB context) {

            var db = new AnimalDB();
            db.Cats.Add(new Cat() { Id = GenerateId(), Name = "Puupy", Color = "brown" });
            db.Cats.Add(new Cat() { Id = GenerateId(), Name = "cuty", Color = "Black" });
            db.SaveChanges();
        }
        public string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }
        public DbSet<Cat> Cats { get; set; }
    }
}