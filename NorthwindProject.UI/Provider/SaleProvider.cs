using Newtonsoft.Json;
using NorthwindProject.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NorthwindProject.UI.Provider
{
    public class SaleProvider
    {
        HttpClient _client;
        public SaleProvider(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> AddAsync(SalesDTO dto)
        {
            //addproducts
            var hede = new StringContent(JsonConvert.SerializeObject(dto));
            hede.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            string veri = "";
            try
            {
                var donenPostDegeri = await _client.PostAsync("addsale", hede);
                if (donenPostDegeri.IsSuccessStatusCode)
                {
                    await donenPostDegeri.Content.ReadAsStringAsync();
                }
                veri = "başarılı";
            }
            catch (Exception ex)
            {
            }
            return veri;
        }
    }
}
