using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace _01_DataBindingToObjects
{
   

    public class Employee : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                TriggerPropertyChanged("FirstName");
                TriggerPropertyChanged("CanFullNameBeGenerated");
            }
        }

        private void TriggerPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                TriggerPropertyChanged("LastName");
                TriggerPropertyChanged("CanFullNameBeGenerated");
            }
        }

        private string _fullName;
        private string _greetMessage;
        private int _id;

        public Employee()
        {
            
        }

        public string FullName
        {
            get { return _fullName; }
            set { 
                _fullName = value;
                TriggerPropertyChanged("FullName");
            }
        }

        

       
        public bool CanFullNameBeGenerated
        {
            get { return !(string.Empty.Equals(FirstName) || string.Empty.Equals(LastName)); }
         
        }

        public override string ToString()
        {
            return string.Format("FirstName = {0}, LastName={1}, FullName={2}", FirstName, LastName, FullName);
        }

        
        

        public string GreetMessage
        {
            get { return _greetMessage; }
            set
            {
                _greetMessage = value;
                TriggerPropertyChanged("GreetMessage");
            }
        }

        
        public void GenerateFullName(object parameter)
        {
            FullName = FirstName + " " + LastName;
        }
        /*private class GenerateFullNameCommandClass : ICommand
        {
            private readonly Employee _employee;

            public GenerateFullNameCommandClass(Employee employee)
            {
                _employee = employee;
            }

            public void Execute(object parameter)
            {
                _employee.GenerateFullName();
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;
        }*/
        public ICommand GenerateFullNameCommand
        {
            get { return new MyCommand(GenerateFullName, o => CanFullNameBeGenerated); }
        }

        public ICommand GreetEmployeeCommand
        {
            get { return new MyCommand(GreetEmployee, o => true); }
        }

        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    TriggerPropertyChanged("Id");
                }
            }
        }

        /* public class GreetEmployeeCommandClass : ICommand
        {
            private readonly Employee _employee;

            public GreetEmployeeCommandClass(Employee employee)
            {
                _employee = employee;
            }

            public void Execute(object parameter)
            {
                
                _employee.GreetEmployee();
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;
        }*/

        private void GreetEmployee(object parameter)
        {
            GreetMessage = "Hi " + (DateTime.Now.Hour < 12 ? "Good Morning " : "Good Afternoon ") + FirstName;
        }

        public event PropertyChangedEventHandler PropertyChanged;


        
    }
}
