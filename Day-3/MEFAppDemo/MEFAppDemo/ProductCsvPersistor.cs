using System.ComponentModel.Composition;
using System.IO;
using System.Linq;

namespace MEFAppDemo
{
    [Export(typeof(IProductPersistor))]
    public class ProductCsvPersistor : IProductPersistor
    {
        public void Persit(Product[] products)
        {
            var streamWriter = new StreamWriter("Products.csv");
            products
                .Select(p => string.Format("{0},{1},{2}", p.Id, p.Name, p.Cost))
                .ForEach(streamWriter.WriteLine);
            streamWriter.Close();
        }
    }
}