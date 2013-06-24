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

namespace _02_LayoutsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_OnClick(object sender, RoutedEventArgs e)
        {
            string status = string.Empty;
            if (TxtUsername.Text == PwdPassword.Password)
            {
                status = "Login successful";
                //TbStatus.Foreground = new SolidColorBrush(new Color(){R=0, G = 255, B=0, A=255});
                //TbStatus.Foreground = new SolidColorBrush(Colors.Green);
                TbStatus.Foreground = Brushes.Green;

            }
            else
            {
                status = "Invalid Credentials";
                TbStatus.Foreground = new SolidColorBrush(new Color() { R = 255, G = 0, B = 0, A = 255 });
            }
            TbStatus.Text = status;
        }
    }
}
