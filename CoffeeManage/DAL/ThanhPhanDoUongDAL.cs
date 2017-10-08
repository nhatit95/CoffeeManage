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
    class ThanhPhanDoUongDAL
    {
        public async Task<List<ThanhPhanDoUong>> GetListThanhPhanDoUong()
        {
            List<ThanhPhanDoUong> tp = null;
            try
            {
                HttpResponseMessage response = await HttpConnect.client.GetAsync("api/ThanhPhanDoUong");
                if (response.IsSuccessStatusCode) tp = await response.Content.ReadAsAsync<List<ThanhPhanDoUong>>();
                return tp;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
