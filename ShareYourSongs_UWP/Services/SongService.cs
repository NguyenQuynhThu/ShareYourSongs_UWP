using Newtonsoft.Json;
using ShareYourSongs_UWP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Net;
using ShareYourSongs_UWP.Pages;
using System.Collections.ObjectModel;

namespace ShareYourSongs_UWP.Services
{
    class SongService : ISongService
    {
        private static string SONG_API_URL = "https://2-dot-backup-server-003.appspot.com/_api/v2/songs";
        private static string UPLOAD_API_URL = "http://2-dot-backup-server-001.appspot.com/upload-file-handle";
        private static string MY_SONG_API_URL = "https://2-dot-backup-server-003.appspot.com/_api/v2/songs/get-mine";
        private static string CONTENT_TYPE = "application/json";
        public Task<Song> Create(Song song)
        {
            return CreateAsync(song);
        }

        private async Task<Song> CreateAsync(Song song)
        {
            try 
            {
                var songJson = JsonConvert.SerializeObject(song);

                HttpContent contentToSend = new StringContent(songJson, Encoding.UTF8, CONTENT_TYPE);
                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(UPLOAD_API_URL, contentToSend);
                var stringContent = await response.Content.ReadAsStringAsync();
                var returnSong = JsonConvert.DeserializeObject<Song>(stringContent);

                Debug.WriteLine(JObject.Parse(stringContent)["id"]);
                return returnSong;
            }
            catch (Exception e)
            {
                throw new System.InvalidOperationException("error", e);
            }
            
        }

        public Task<List<Song>> GetAllSongs()
        {
            return GetAllSongsAsync();
        }

        public async Task<List<Song>> GetAllSongsAsync()
        {
            List<Song> songs = new List<Song>();
            
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + Login.Token);
                var response = await httpClient.GetAsync(SONG_API_URL);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var stringContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Song>>(stringContent);
                }
                return null;

            }
            catch (Exception e)
            {
                throw new System.InvalidOperationException("error", e);
            }
        }


        public Task<List<Song>> GetMySongs()
        {
            return GetMySongsAsync();
        }

        public async Task<List<Song>> GetMySongsAsync()
        {
            List<Song> songs = new List<Song>();

            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + Login.Token);
                var response = await httpClient.GetAsync(MY_SONG_API_URL);
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    var stringContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Song>>(stringContent);
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
