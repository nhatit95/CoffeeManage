using CoffeeManage.Presenter;
using CoffeeManage.View.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoffeeManage
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window,ILogin
    {
        LoginPresenter pre;
        public Login()
        {
            
        }
        public string Email
        {
            get
            {
                return email.Text;
            }

            set
            {
                email.Text = value;
            }
        }
        public string MatKhau
        {
            get
            {
                return password.Password;
            }

            set
            {
                password.Password = value;
            }
        }
        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }

            set
            {
                _message = value;
                MessageBox.Show(_message);
            }
        }

        
        private bool _close;
        public bool Close
        {
            get
            {
                return _close;
            }
            set
            {
                _close = value;
                if (_close) this.Close();
            }
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            pre = new LoginPresenter(this);
        }

        private void txtPassword_Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) pre = new LoginPresenter(this);

        }
    }
}
