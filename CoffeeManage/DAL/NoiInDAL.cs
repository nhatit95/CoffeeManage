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
    class NoiInDAL
    {
        public async Task<List<NoiIn>> GetListNoiIn()
        {
            List<NoiIn> ni = null;
            try
            {
                HttpResponseMessage response = await HttpConnect.client.GetAsync("api/NoiIn");
                if (response.IsSuccessStatusCode) ni = await response.Content.ReadAsAsync<List<NoiIn>>();
                return ni;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
