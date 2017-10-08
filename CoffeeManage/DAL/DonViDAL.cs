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
    class DonViDAL
    {
        public async Task<List<DonVi>> GetListDonVi()
        {
            List<DonVi> dv = null;
            try
            {
                HttpResponseMessage response = await HttpConnect.client.GetAsync("api/DonVi");
                if (response.IsSuccessStatusCode) dv = await response.Content.ReadAsAsync<List<DonVi>>();
                return dv;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
