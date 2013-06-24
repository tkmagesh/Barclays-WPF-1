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
    /// Interaction logic for PropertyBindingAdvanced.xaml
    /// </summary>
    public partial class PropertyBindingAdvanced : Window
    {
        public PropertyBindingAdvanced()
        {
            InitializeComponent();
            TbTax.SetBinding(TextBlock.TextProperty, new Binding()
                {
                    ElementName = "SliderTax",
                    Path = new PropertyPath("Value"),
                    Mode = BindingMode.TwoWay,
                    StringFormat = "00"
                });
            /*TbTax.SetBinding(TextBlock.ForegroundProperty, new Binding()
                {
                    ElementName = "SliderTax",
                    Path = new PropertyPath("Value"),
                    Converter = new SliderValueToSolidBrushConverter()
                });*/
        }
    }
}
