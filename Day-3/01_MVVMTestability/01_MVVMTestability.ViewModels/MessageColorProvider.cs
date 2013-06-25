using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using _01_MVVMTestability.Domain;
using _01_MVVMTestability.ViewModels.Annotations;

namespace _01_MVVMTestability.ViewModels
{
    public class MessageColorProvider : INotifyPropertyChanged
    {
        private readonly ITimeService _timeService;
        private Brush _brush;

        public MessageColorProvider(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public void ResetColor()
        {
            _brush = _timeService.GetCurrentDateTime().Hour < 12 ? Brushes.Green : Brushes.Red;
            OnPropertyChanged("MessageColor");
        }

        public Brush MessageColor
        {
            get { return _timeService.GetCurrentDateTime().Hour < 12 ? Brushes.Green : Brushes.Red; ; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}