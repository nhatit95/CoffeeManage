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
    class ChucVuDAL
    {
        public async Task<ChucVu> GetChucVu(string id)
        {
            ChucVu cv = null;
            try
            {
                HttpResponseMessage response = await HttpConnect.client.GetAsync("api/ChucVu/?id=" + id);
                if (response.IsSuccessStatusCode) cv = await response.Content.ReadAsAsync<ChucVu>();
                return cv;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
