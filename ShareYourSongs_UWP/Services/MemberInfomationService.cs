using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ShareYourSongs_UWP.Models;

namespace ShareYourSongs_UWP.Services
{
    class MemberInfomationService
    {
        private static readonly string MEMBERINFORMATION_API_URL = "https://2-dot-backup-server-003.appspot.com/_api/v2/members/information";
        public async Task<Member> GetMemberInformation(string token)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + token);
                var response = await httpClient.GetAsync(MEMBERINFORMATION_API_URL);
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    var stringContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Member>(stringContent);
                }
                return null;
            }
            catch (Exception e)
            {
                throw new System.InvalidOperationException("error", e);
            }

        }
    }
}
