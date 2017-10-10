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
    class BanDAL
    {
        public async Task<List<Ban>> GetListBan()
        {
            List<Ban> ba = null;
            try
            {
                HttpResponseMessage response = await HttpConnect.client.GetAsync("api/Ban");
                if (response.IsSuccessStatusCode) ba = await response.Content.ReadAsAsync<List<Ban>>();
                return ba;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
