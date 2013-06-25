using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _01_DataBindingToObjects
{
    /// <summary>
    /// Interaction logic for ListBinding.xaml
    /// </summary>
    public partial class ListBinding : Window
    {
        private ObservableCollection<Employee> employees;

        public ListBinding()
        {
            InitializeComponent();
            employees = new ObservableCollection<Employee>()
                {
                    new Employee() {FirstName = "Magesh", LastName = "K", Id = 101},
                    new Employee() {FirstName = "Suresh", LastName = "K", Id = 102},
                    new Employee() {FirstName = "Ganesh", LastName = "E", Id = 103},
                    new Employee() {FirstName = "Rajesh", LastName = "P", Id = 104}
                };
            
            ListEmployees.ItemsSource = employees;
        }

        private void BtnAddEmployee_OnClick(object sender, RoutedEventArgs e)
        {
            employees.Add(new Employee()
                {
                    FirstName = "Yuva", LastName = "K", Id = 105
                });
            MessageBox.Show(employees.Count.ToString());
        }
    }
}
