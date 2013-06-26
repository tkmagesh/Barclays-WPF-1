using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using _01_MVVMTestability.Domain;
using _01_MVVMTestability.ViewModels;

namespace _01_MVVMTestability
{
    /// <summary>
    /// Interaction logic for GreetWindow.xaml
    /// </summary>
    public partial class GreetWindow : Window
    {
        public GreetWindow()
        {
            InitializeComponent();

            this.DataContext = ((App) Application.Current).Container.GetExportedValue<GreeterViewModel>();
          
            
            //var greeterViewModel = container.GetExportedValue<GreeterViewModel>();
            //MessageBox.Show("Done");
        }
    }
}
