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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DependencyPropertiesDemo
{
    /// <summary>
    /// Interaction logic for DataEntryField.xaml
    /// </summary>
    public partial class DataEntryField : UserControl
    {
        private string _caption;
        private string _value;

        public DataEntryField()
        {
            InitializeComponent();
        }

        /*public string Caption
        {
            get { return _caption; }
            set
            {
                _caption = value;
                this.LblAnchorCaption.Content = value;
            }
        }

        public string Value
        {
            get { return this.TxtAnchorValue.Text; }
            set
            {
                _value = value;
                this.TxtAnchorValue.Text = value;
            }
        }*/



        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Caption.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(DataEntryField), new PropertyMetadata("[Caption]:", CaptionPropertyChangedCallback));

        private static void CaptionPropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            var dataEntryField = (DataEntryField) dependencyObject;
            dataEntryField.LblAnchorCaption.Content = dependencyPropertyChangedEventArgs.NewValue;
        }



        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(string), typeof(DataEntryField), new PropertyMetadata(string.Empty, ValuePropertyChangedCallback));

        private static void ValuePropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            var dataEntryField = (DataEntryField)dependencyObject;
            dataEntryField.TxtAnchorValue.Text = dependencyPropertyChangedEventArgs.NewValue.ToString();
        }
    }
}
