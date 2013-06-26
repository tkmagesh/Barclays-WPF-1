using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using _01_MVVMTestability.Domain;
using _01_MVVMTestability.ViewModels;

namespace _01_MVVMTestability
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public CompositionContainer Container { get; set; }
        public App()
        {
            var viewCatalog = new AssemblyCatalog(typeof(GreetWindow).Assembly);
            var viewModelCatalog = new AssemblyCatalog(typeof(GreeterViewModel).Assembly);
            var domainCatalog = new AssemblyCatalog(typeof(Greeter).Assembly);
            var aggregateCatalog = new AggregateCatalog(viewCatalog, viewModelCatalog, domainCatalog);

            this.Container = new CompositionContainer(aggregateCatalog);
        }
    }
}
