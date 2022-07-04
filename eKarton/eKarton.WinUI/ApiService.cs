using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.WinUI
{
    public class ApiService
    {
        private string _route = null;
        public ApiService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>()
        {
            var url = $"{Properties.Settings.Default.ApiUrl}/{_route}";
            var result = await url.GetJsonAsync<T>();
            return result;
        }
        public async Task<T> GetById<T>(object Id)
        {

            var url = $"{Properties.Settings.Default.ApiUrl}/{_route}/{Id}";
            var result = await url.GetJsonAsync<T>();
            return result;
        }
    }
}
