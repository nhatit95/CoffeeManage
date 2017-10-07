using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.View.Login
{
    public interface ILogin
    {
        string Email { get; set; }
        string MatKhau { get; set; }
        void Message(string message);
        void CloseForm();
        void LoginSystem();
    }
}
