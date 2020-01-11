using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareYourSongs_UWP.Models
{
    public class Song
    {
        public long id { get; set; }
        public string name { get; set; }
        public string singer { get; set; }
        public string author { get; set; }
        public string thumbnail { get; set; }
        public string link { get; set; }

        public Dictionary<string, string> ValidateUpload()
        {
            var errors = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(this.name))
            {
                errors.Add("name", "Song name is required!");
            }

            if (string.IsNullOrEmpty(this.singer))
            {
                errors.Add("singer", "Singer is required!");
            }

            if (string.IsNullOrEmpty(this.author))
            {
                errors.Add("author", "Author is required!");
            }

            if (string.IsNullOrEmpty(this.thumbnail))
            {
                errors.Add("thumbnail", "Thumbnail is required!");
            }

            if (string.IsNullOrEmpty(this.link))
            {

                errors.Add("link", "Link is required!");
            }

            return errors;
        }

    }
}
