using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ShareYourSongs_UWP.Models;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ShareYourSongs_UWP.Services
{
    class MemberService : IMemberService
    {
        private static string REGISTER_API_URL = "https://2-dot-backup-server-003.appspot.com/_api/v2/members";
        private static string CONTENT_TYPE = "application/json";
        public Task<Member> Create(Member member)
        {
            return CreateAsync(member);
        }

        private async Task<Member> CreateAsync(Member member)
        {
            var memberJson = JsonConvert.SerializeObject(member);

            HttpContent contentToSend = new StringContent(memberJson,Encoding.UTF8, CONTENT_TYPE);
            HttpClient httpClient = new HttpClient();
            
            var response = await httpClient.PostAsync(REGISTER_API_URL, contentToSend);
            var stringContent = await response.Content.ReadAsStringAsync();
            var returnMember = JsonConvert.DeserializeObject<Member>(stringContent);

            Debug.WriteLine(JObject.Parse(stringContent)["id"]);
            return returnMember;
        }


    }
}
