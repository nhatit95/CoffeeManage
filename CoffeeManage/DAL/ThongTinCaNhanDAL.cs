using CoffeeManage.DTO;
using CoffeeManage.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.DAL
{
    class ThongTinCaNhanDAL
    {
        public async Task<ThongTinCaNhan> GetThongTinCaNhan(string email)
        {
            ThongTinCaNhan tt = null;
            try
            {
                HttpResponseMessage response = await HttpConnect.client.GetAsync("api/ThongTinCaNhan/?id=" + email);
                if (response.IsSuccessStatusCode)
                    tt = await response.Content.ReadAsAsync<ThongTinCaNhan>();
                return tt;
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi :" + e);
                return null;
            }

        }
    }
}
