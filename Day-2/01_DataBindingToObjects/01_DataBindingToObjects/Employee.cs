using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace _01_DataBindingToObjects
{
    public class Employee : INotifyPropertyChanged
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                TriggerPropertyChanged("FirstName");
                TriggerPropertyChanged("FullName");
            }
        }

        private void TriggerPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public override string ToString()
        {
            return string.Format("FirstName = {0}, LastName={1}, FullName={2}", FirstName, LastName, FullName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
