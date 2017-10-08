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
    public class DoUongDAL
    {
        public async Task<List<DoUong>> GetListDoUong()
        {
            List<DoUong> dl = null;
            try
            {
                HttpResponseMessage response = await HttpConnect.client.GetAsync("api/DoUong");
                if (response.IsSuccessStatusCode) dl = await response.Content.ReadAsAsync<List<DoUong>>();
                return dl;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
