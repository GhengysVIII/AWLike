using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionToApiToolbox.ApiConnector
{
    public class ApiConnector
    {
        public string Url { get; set; }
        public Dictionary<string, string> paramList = new Dictionary<string, string>();
        public ApiConnector(string Url)
        {
            this.Url = Url;
        }

        //public async TResult Get<TResult>(Func<string, TResult> ToObject)
        //{
        //    string json = getJSON().Result;
        //}




        public async Task<string> GetJSON()
        {
            using (HttpClient http = new HttpClient())
            {
                HttpResponseMessage message = await http.GetAsync(Url);
                return await message.Content.ReadAsStringAsync();

            }
        }

        public async Task<string>  PostJSON<TResult>(TResult param) where TResult : class
        {
            using (HttpClient c = new HttpClient())
            {

                


                //HttpStringContent stringContent = new HttpStringContent(
                //        "{ \"firstName\": \"John\" }",
                //        UnicodeEncoding.UTF8,
                //        "application/json");

                //HttpClient client = new HttpClient();
                //var content = new FormUrlEncodedContent(paramList);
                

                //c.DefaultRequestHeaders.Accept.Clear();
                c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                string Json = JsonConvert.SerializeObject(param);
                HttpContent Content = new StringContent(Json);
                Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                HttpResponseMessage Response = null;

                try
                {

                    Response = c.PostAsync(Url, Content).Result;
                
                }
                catch (Exception ex)
                {

                    throw ex;
                }


                Response.EnsureSuccessStatusCode();

                if (Response.IsSuccessStatusCode)
                {
                    Console.WriteLine(Response.StatusCode);
                    Console.WriteLine();

                    string Result = await Response.Content.ReadAsStringAsync();
                    return Result;

                    //return JsonConvert.DeserializeObject<TResult>(Result);
                }
                return null;



                //HttpResponseMessage message = await c.PostAsync(Url, new StringContent(json));




                //return await message.Content.ReadAsStringAsync();
            }
        }
    }
}
