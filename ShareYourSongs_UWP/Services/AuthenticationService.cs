using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareYourSongs_UWP.Models;

namespace ShareYourSongs_UWP.Services
{
    class AuthenticationService
    {
        private static string LOGIN_API_URL = "https://2-dot-backup-server-003.appspot.com/_api/v2/members/authentication";
        private static string CONTENT_TYPE = "application/json";

        public async Task<string> LoginTask(Member member)
        {
            var loginJson = JsonConvert.SerializeObject(member);
      
            HttpContent contentToSend = new StringContent(loginJson,Encoding.UTF8, CONTENT_TYPE);
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.PostAsync(LOGIN_API_URL, contentToSend);
            var stringContent = await response.Content.ReadAsStringAsync();

            return (string)JObject.Parse(stringContent)["token"];
        }
    }
}
