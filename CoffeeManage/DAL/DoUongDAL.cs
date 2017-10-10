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
        public async Task<DoUong> GetDoUong(string id)
        {
            DoUong du = null;
            try
            {
                HttpResponseMessage response = await HttpConnect.client.GetAsync("api/DoUong/?id=" + id);
                if (response.IsSuccessStatusCode)
                    du = await response.Content.ReadAsAsync<DoUong>();
                return du;
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi :" + e);
                return null;
            }

        }
        public async Task<bool> InsertDoUong(DoUong du)
        {
            try
            {
                HttpResponseMessage response = await HttpConnect.client.PostAsJsonAsync("api/DoUong", du);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsAsync<bool>();
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
