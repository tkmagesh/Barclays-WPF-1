using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using _01_MVVMTestability.Domain;
using System.ComponentModel.Composition.Hosting;
using System.Windows;

namespace _01_MVVMTestability.ViewModels
{
    [Export()]
    public class GreeterViewModel : INotifyPropertyChanged
    {
        private string _name;
        private string _greetMessage;
        private ICommand _greetCommand;
        private TimeService _timeService;
        private Greeter _greeter;
        private MessageColorProvider _messageColorProvider;
        private Brush _messageColor;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
               
            }
        }

        public MessageColorProvider MsgColorProvider
        {
            get { return _messageColorProvider; }
            set { _messageColorProvider = value; }
        }

        public string GreetMessage
        {
            get { return _greetMessage; }
            set { _greetMessage = value;
            OnPropertyChanged("GreetMessage");}
        }

        public ICommand GreetCommand
        {
            get
            {
                return _greetCommand;
            }
            set
            {
                _greetCommand = value;
            }
        }

        [Import(typeof(ITimeService))]
        public TimeService TimeService
        {
            get { return _timeService; }
            set { _timeService = value; }
        }

        [Import(typeof(Greeter))]
        public Greeter Greeter
        {
            get { return _greeter; }
            set { _greeter = value; }
        }

        public GreeterViewModel()
        {
            //_timeService = new TimeService();
            //_greeter = new Greeter(_timeService);
            
            _greetCommand = new MyCommand(GenerateGreetMsg, o => true);
            //_messageColorProvider = new MessageColorProvider(_timeService);
        }

        public Brush MessageColor
        {
            get { return _messageColor; }
            set { 
                _messageColor = value;
                OnPropertyChanged("MessageColor");
            }
        }

        private void GenerateGreetMsg(object obj)
        {
            GreetMessage = Greeter.Greet(Name);
            MessageColor = _timeService.GetCurrentDateTime().Hour < 12 ? Brushes.Green : Brushes.Red;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
