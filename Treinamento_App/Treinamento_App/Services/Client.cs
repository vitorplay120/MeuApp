using System;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;
using System.Runtime.Serialization.Json;
using System.IO;
using Treinamento_App.Models;

namespace Treinamento_App.Services
{
    public class Client
    {
      public  Response ResponseAPI { get; set; }

      public static string Key = "e57bdade95be4b86bd0415cf893f917f";

      public void  GET(string Query)
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(Query);

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Key);


            var uri = "https://testandoultimavez.azure-api.net/" + queryString;

            try
            {
                var response = client.GetAsync(uri);
                string resultadoJSON =  response.Result.Content.ToString();
                ResponseAPI = Deserialize<Response>(resultadoJSON);


            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }


        }

        public static T Deserialize<T>(string json)
        {
            var obj = Activator.CreateInstance<T>();
            using (var memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                var serializer = new DataContractJsonSerializer(obj.GetType());
                obj = (T)serializer.ReadObject(memoryStream);
                return obj;
            }
        }

    }
}