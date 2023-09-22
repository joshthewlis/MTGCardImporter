using MTGCardImporter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MTGCardImporter.Base
{
    static class JSON
    {

        public static T? loadJsonFromURI<T>(string uri) where T : class
        {
            using (var httpClient = new HttpClient())
            {
                var result = Task.Run(async () => await httpClient.GetFromJsonAsync<Result<T>>(uri)).Result;
                if (result == null)
                    return default(T);

                return result.data;
            }
        }

        public static async Task<T?> loadJsonFromURIAsync<T>(string uri) where T : class
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetFromJsonAsync<Result<T>>(uri);
                if (result == null)
                    return default(T);

                return result.data;
            }
        }

    }


    class Result<T> where T : class
    {

        public Meta meta { get; set; } = new Meta();
        public T? data { get; set; } = default(T);

    }

}
