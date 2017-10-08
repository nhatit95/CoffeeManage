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
    class NguyenLieuDAL
    {
        public async Task<List<NguyenLieu>> GetListNguyenLieu()
        {
            List<NguyenLieu> nl = null;
            try
            {
                HttpResponseMessage response = await HttpConnect.client.GetAsync("api/NguyenLieu");
                if (response.IsSuccessStatusCode) nl = await response.Content.ReadAsAsync<List<NguyenLieu>>();
                return nl;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public async Task<bool> InsertNguyenLieu(NguyenLieu nl)
        {
            try
            {
                HttpResponseMessage response = await HttpConnect.client.PostAsJsonAsync("api/NguyenLieu", nl);
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
