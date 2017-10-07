using CoffeeManage.View.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.Presenter
{
    class LoginPresenter
    {
        ILogin loginView;
        HttpConnect connect;
        public LoginPresenter(ILogin loginView)
        {
            this.loginView = loginView;
        }
        public void Login()
        {
            try
            {
                //connect = new HttpConnect(loginView.Email, loginView.MatKhau);
                connect = new HttpConnect("lesan1995@gmail.com", "#123Abc");
                Home h = new Home();
                loginView.CloseForm();
            }
            catch (Exception)
            {
                loginView.Message("Tai Khoan Khong Hop Le");
            }
        }

    }
}
