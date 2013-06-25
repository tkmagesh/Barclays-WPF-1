using System.ComponentModel.Composition;

namespace MEFAppDemo
{
    [Export(typeof(IProductDataSource))]
    public class ProductInMemoryDataSource : IProductDataSource
    {
        public Product[] GetProducts()
        {
            return new Product[]
                {
                    new Product(){Id = 101, Name = "Pen", Cost = 101},
                    new Product(){Id = 131, Name = "Ken", Cost = 102},
                    new Product(){Id = 121, Name = "Den", Cost = 103},
                    new Product(){Id = 111, Name = "Ten", Cost = 104}

                };
        }
    }
}