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
            pre = new LoginPresenter(this);
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
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginSystem();
        }
        public void LoginSystem()
        {
            pre.Login();
        }
        private void txtPassword_Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) LoginSystem();

        }
        public void CloseForm()
        {
            this.Close();
        }
        public void Message(string message)
        {
            MessageBox.Show(message);
        }
    }
}
