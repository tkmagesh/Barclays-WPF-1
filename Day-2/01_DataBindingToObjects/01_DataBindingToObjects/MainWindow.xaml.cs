using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace _01_DataBindingToObjects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*var employee = new Employee()
                {
                    FirstName = "Magesh", LastName = "Kuppan"
                };*/

            //Type - 1
            /*TxtFirstName.SetBinding(TextBox.TextProperty,
                                    new Binding() { Source = employee, Path = new PropertyPath("FirstName") });*/

            //Type-2
            /*TxtFirstName.DataContext = employee;
            TxtFirstName.SetBinding(TextBox.TextProperty,
                                    new Binding() {Path = new PropertyPath("FirstName") });

            TxtLastName.DataContext = employee;
            TxtLastName.SetBinding(TextBox.TextProperty,
                                    new Binding() { Path = new PropertyPath("LastName") });

            TbFullName.DataContext = employee;
            TbFullName.SetBinding(TextBlock.TextProperty,
                                    new Binding() { Path = new PropertyPath("FullName") });
            */

            //Type-3
            //Setting the DataContext to the parent (Grid) and it flows throught the child controls
            /*GridLayoutRoot.DataContext = employee;
            TxtFirstName.SetBinding(TextBox.TextProperty,
                                    new Binding() { Path = new PropertyPath("FirstName") });

            
            TxtLastName.SetBinding(TextBox.TextProperty,
                                    new Binding() { Path = new PropertyPath("LastName") });

            
            TbFullName.SetBinding(TextBlock.TextProperty,
                                    new Binding() { Path = new PropertyPath("FullName") });
            */

            //Type-4
            //Setting the DataContext to the window and it flows throught the child controls
            /*this.DataContext = employee;
            TxtFirstName.SetBinding(TextBox.TextProperty,
                                    new Binding() { Path = new PropertyPath("FirstName") });


            TxtLastName.SetBinding(TextBox.TextProperty,
                                    new Binding() { Path = new PropertyPath("LastName") });


            TbFullName.SetBinding(TextBlock.TextProperty,
                                    new Binding() { Path = new PropertyPath("FullName") });*/
        }

        private void BtnPrintEmployee_Click(object sender, RoutedEventArgs e)
        {
            /*var btn = (Button) sender;
            Debug.WriteLine(btn.DataContext);*/
            var emp = (Employee)GridLayoutRoot.Resources["DataBindingObject"];
            Debug.WriteLine(emp);
        }

        private void BtnChangeEmployee_Click(object sender, RoutedEventArgs e)
        {
            var emp = (Employee)GridLayoutRoot.Resources["DataBindingObject"];
            emp.FirstName = "Yuvaraj";
            Debug.WriteLine("After changing the firstname of the object");
            Debug.WriteLine(emp);
        }
    }
}
