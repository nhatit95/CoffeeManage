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
    class KhuVucDAL
    {
        public async Task<List<KhuVuc>> GetListKhuVuc()
        {
            List<KhuVuc> kv = null;
            try
            {
                HttpResponseMessage response = await HttpConnect.client.GetAsync("api/KhuVuc");
                if (response.IsSuccessStatusCode) kv = await response.Content.ReadAsAsync<List<KhuVuc>>();
                return kv;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public async Task<KhuVuc> GetKhuVuc(string id)
        {
            KhuVuc kv = null;
            try
            {
                HttpResponseMessage response = await HttpConnect.client.GetAsync("api/KhuVuc/?id=" + id);
                if (response.IsSuccessStatusCode)
                    kv = await response.Content.ReadAsAsync<KhuVuc>();
                return kv;
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi :" + e);
                return null;
            }

        }
    }
}
