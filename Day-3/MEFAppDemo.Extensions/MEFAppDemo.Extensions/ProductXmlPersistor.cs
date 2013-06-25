using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace MEFAppDemo.Extensions
{
    [Export(typeof(IProductPersistor))]
    public class ProductXmlPersistor : IProductPersistor
    {
        public void Persit(Product[] products)
        {
            new XElement("Products", products.Select(p => new XElement("Product", new XElement("Id", p.Id), new XElement("Name",p.Name), new XElement("Cost",p.Cost.ToString("c"))))).Save("Products.xml");
        }
    }
}
