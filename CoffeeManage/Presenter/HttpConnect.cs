using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.Presenter
{
    class HttpConnect
    {
        public static HttpClient client=new HttpClient();
        public static string email="";
        public HttpConnect(string userName,string password)
        {
            email = userName;
            string token = GetToken(userName, password);
            var obj = JObject.Parse(token);
            client = new HttpClient();
            client.BaseAddress = new Uri("http://192.168.1.18/cafeserver/api");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue((string)obj.SelectToken("token_type"), (string)obj.SelectToken("access_token"));
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        string GetToken(string userName, string password)
        {
            StringContent content = new StringContent("username=" + userName + "&password=" + password + "&grant_type=password");
            var response =
                   client.PostAsync("http://192.168.1.18/cafeserver/Token", content).Result;
            return response.Content.ReadAsStringAsync().Result;
        }
        
    }
}
