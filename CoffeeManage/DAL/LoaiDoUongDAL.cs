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
    class LoaiDoUongDAL
    {
        public async Task<List<LoaiDoUong>> GetListLoaiDoUong()
        {
            List<LoaiDoUong> ldl = null;
            try
            {
                HttpResponseMessage response = await HttpConnect.client.GetAsync("api/LoaiDoUong");
                if (response.IsSuccessStatusCode) ldl = await response.Content.ReadAsAsync<List<LoaiDoUong>>();
                return ldl;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
