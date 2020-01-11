using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ShareYourSongs_UWP.Models;
using ShareYourSongs_UWP.Services;
using System.Diagnostics;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ShareYourSongs_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddSong : Page
    {
        private ISongService _service;

        public AddSong()
        {
            this.InitializeComponent();
            this._service = new SongService();
        }

        private async void SubmitData(object sender, RoutedEventArgs e)
        {
            var song = new Song()
            {
                name = TxtName.Text,
                singer = TxtSinger.Text,
                author = TxtAuthor.Text,
                thumbnail = TxtThumbnail.Text,
                link = TxtLink.Text,
            };

            var errors = song.ValidateUpload();

            if (errors.Count > 0)
            {
                HandleError(errors);
            }
            else
            {
                song = await this._service.Create(song);
                Debug.WriteLine(song.id);
            }
        
        }

        private void HandleError(Dictionary<string, string> errors)
        {
            if (errors.ContainsKey("name"))
            {
                Name_Error.Text = errors["name"];
            }

            if (errors.ContainsKey("singer"))
            {
                Singer_Error.Text = errors["singer"];
            }

            if (errors.ContainsKey("author"))
            {
                Author_Error.Text = errors["author"];
            }

            if (errors.ContainsKey("thumbnail"))
            {
                Thumbnail_Error.Text = errors["thumbnail"];
            }

            if (errors.ContainsKey("link"))
            {
                Link_Error.Text = errors["link"];
            }
        }


    }
    

}
    