namespace Bridge
{
    partial class Program
    {
        public class Products : Storage<Product>
        {
            public Products(ISaveLoad<Product> saveLoad) : base(saveLoad) { }
        }

    }

}
