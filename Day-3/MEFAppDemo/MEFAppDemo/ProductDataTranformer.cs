using System.ComponentModel.Composition;

namespace MEFAppDemo
{
    [Export]
    public class ProductDataTranformer
    {
        [Import(typeof(IProductDataSource))]
        public IProductDataSource ProductDataSource { get; set; }


        [ImportMany(typeof(IProductPersistor))]
        public IProductPersistor[] ProductPersistors { get; set; }
        
        public void Transform()
        {
            foreach (var productPersistor in ProductPersistors)
            {
                productPersistor.Persit(ProductDataSource.GetProducts());    
            }
            
        }
    }
}