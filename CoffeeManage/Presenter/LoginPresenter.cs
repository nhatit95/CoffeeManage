using CoffeeManage.Model;
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
            try
            {
               // connect = new HttpConnect(loginView.Email, loginView.MatKhau);
               connect = new HttpConnect("lesan1995@gmail.com", "#123Abc");
                Home h = new Home();
                loginView.Close = true;
            }
            catch(Exception)
            {
                // loginView.Message = "Tai Khoan Khong Hop Le";
                Home h = new Home();
                loginView.Close = true;
            }
            
        }

    }
}
