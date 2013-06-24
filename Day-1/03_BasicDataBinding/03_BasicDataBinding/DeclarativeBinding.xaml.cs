using System;
using System.Collections.Generic;
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

namespace _03_BasicDataBinding
{
    /// <summary>
    /// Interaction logic for DeclarativeBinding.xaml
    /// </summary>
    public partial class DeclarativeBinding : Window
    {
        public DeclarativeBinding()
        {
            InitializeComponent();
            //TbSample.SetBinding(TextBlock.TextProperty, new Binding() {ElementName = "TxtSample", Path = new PropertyPath("Text.Length")});
            
        }
    }
}
