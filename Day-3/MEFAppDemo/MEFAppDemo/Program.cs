using System;
using System.ComponentModel.Composition.Hosting;
using System.Text;

namespace MEFAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblyCatalog = new AssemblyCatalog(typeof (ProductDataTranformer).Assembly);
            var directoryCatalog = new DirectoryCatalog("Plugins");
            var aggregateCatalog = new AggregateCatalog(assemblyCatalog, directoryCatalog);

            var container = new CompositionContainer(aggregateCatalog);
            var dataTranformer = container.GetExportedValue<ProductDataTranformer>();
               
            dataTranformer.Transform();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
