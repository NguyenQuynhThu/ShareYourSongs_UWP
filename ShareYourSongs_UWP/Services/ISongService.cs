using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareYourSongs_UWP.Models;

namespace ShareYourSongs_UWP.Services
{
    interface ISongService
    {
        Task<Song> Create(Song song);
        Task<List<Song>> GetAllSongs();
        Task<List<Song>> GetMySongs();

    }
}
