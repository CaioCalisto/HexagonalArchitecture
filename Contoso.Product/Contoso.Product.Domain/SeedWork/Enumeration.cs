namespace Contoso.Product.Domain.SeedWork
{
    public abstract class Enumeration : IComparable
    {
        public string Name { get; private set; }

        public int Id { get; private set; }

        protected Enumeration(int id, string name) => (Id, Name) = (id, name);

        public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);
    }
}
