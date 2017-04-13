using System;

namespace EFCodeFirstAnimalDb
{
    public class Cat
    {
        private string _id;
        private string _name;
        private string _color;

        public string Id

        {
            get { return _id; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))throw new Exception("Please enter Id.");
                _id = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))throw new Exception("Please enter name.");
                _name = value;
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception("Please enter color.");
                _color = value;
            }
        }

        //public Name Name1 { get; set; }

        //public void Update(Name name)
        //{
        //    if (name == null) throw new Exception("");
        //    Name1 = name;
        //}
        //public Cat(string name ,string color)
        //{
        //    if(string.IsNullOrWhiteSpace(name))throw new Exception("");
        //    if (string.IsNullOrWhiteSpace(color)) throw new Exception("");
        //    Name = name;
        //    Color = color;
        //}
    }

    //public class Name
    //{
    //    public string FirstName { get; set; }
    //}
    //public class Test:Cat
    //{
    //    public void Get()
    //    {
    //        this.Name = "";
    //        //var cat = new Cat("nn", "red");
    //        //cat.Name = "rakes";
    //    }
    //}
   
    
}