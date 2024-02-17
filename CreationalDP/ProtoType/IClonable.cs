

namespace CreationalDP.ProtoType
{
    public interface ICustomClonable
    {
        public ICustomClonable Clone();
    }

    public class Product : ICustomClonable
    {
        public Product(int id,string name)
        {
            Name = name;
            Id = id;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public ICustomClonable Clone()
        {
            return new Product(this.Id, this.Name);
        }
    }
    public class Product2 : ICloneable
    {
        public Product2(int id, string name)
        {
            Name = name;
            Id = id;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public object Clone()
        {
            return new Product(this.Id, this.Name);
        }
    }
}
