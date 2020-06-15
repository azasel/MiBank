using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MiBank {
    public class apiManager {


        string initialData;
        
        public HttpClient client { get; set; } = new HttpClient();




       



        async public Task<string> GetResponse(string loginID) {

            using (HttpResponseMessage response = await client.GetAsync("https://titan.csit.rmit.edu.au/~e07582/wdt/services/logins/")) {
                using (HttpContent content = response.Content) {

                    string myContent = await content.ReadAsStringAsync();
                    if (myContent != null) {
                        //Console.WriteLine($"content {myContent}");
                        dynamic jsonObj = JsonConvert.DeserializeObject<dynamic>(myContent);
                        foreach (dynamic item in jsonObj) {
                            //Console.WriteLine(item["LoginID"]);
                            string test = item["LoginID"];
                            if (String.Compare(test, loginID) == 0) {
                                return item["PasswordHash"];
                            }
                        }
                    }
                    else {
                        Console.WriteLine($"Just No Content");
                        return "";

                    }
                }
            }

            return "";

        }
    }
}
