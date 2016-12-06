using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace TestLOLApp.Content
{
    public class APICalls
    {
        public static T CallApi<T>(string route, string apiQuery)
        {
            var key = System.Configuration.ConfigurationManager.AppSettings["APIKey"];
            var apiCall = route + apiQuery + key;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(route);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(apiCall).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    //deserialize json to object
                    T dto = JsonConvert.DeserializeObject<T>(json);
                    return dto;
                }
                else
                {
                    //TODO
                    return default(T);
                }
            }
        }

        public static T CallAPIMap<T>(string route, string apiQuery)
        {
            var key = System.Configuration.ConfigurationManager.AppSettings["APIKey"];
            var apiCall = route + apiQuery + key;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(route);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(apiCall).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    //deserialize json to object
                    T dto = JsonConvert.DeserializeObject<T>(json);
                    return dto;
                }
                else
                {
                    //TODO
                    return default(T);
                }
            }
        }

    }
}