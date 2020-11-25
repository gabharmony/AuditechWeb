using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Auditech_Web.Services
{
    public class Request : IRequest
    {
        //GET
        public async Task<TResult> GetAsync<TResult>(string uri)
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.GetAsync(uri);

            string serialized = await response.Content.ReadAsStringAsync();
            if (serialized == "Login Inválido")
            {
                serialized = "{'idUsuario': 0}";
            }

            TResult result = await Task.Run(() =>
               JsonConvert.DeserializeObject<TResult>(serialized));

            return result;
        }

        //DELETE
        public async Task<int> DeleteAsync(string uri)
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.DeleteAsync(uri);

            string serialized = await response.Content.ReadAsStringAsync();
            return Convert.ToInt32(serialized);
        }

        //POST
        public async Task<int> PostAsync<TResult>(string uri, TResult data)
        {
            HttpClient httpClient = new HttpClient();

            var content = new StringContent(JsonConvert.SerializeObject(data));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await httpClient.PostAsync(uri, content);

            string serialized = await response.Content.ReadAsStringAsync();
            return Convert.ToInt32(serialized);
        }

        //PUT
        public async Task<int> PutAsync<TResult>(string uri, TResult data)
        {
            HttpClient httpClient = new HttpClient();

            var content = new StringContent(JsonConvert.SerializeObject(data));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await httpClient.PutAsync(uri, content);

            string serialized = await response.Content.ReadAsStringAsync();
            return Convert.ToInt32(serialized);
        }
    }
}