using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareYourSongs_UWP.Models
{
    public class Member
    {
        public long id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string avatar { get; set; }
        public int gender { get; set; }
        public string email { get; set; }
        public string birthday { get; set; }

        public Dictionary<string, string> ValidateRegister()
        {
            var errors = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(this.firstName))
            {
                errors.Add("firstName", "First name is required!");
            }

            if (string.IsNullOrEmpty(this.lastName))
            {
                errors.Add("lastName", "Last name is required!");
            }

            if (string.IsNullOrEmpty(this.password))
            {
                errors.Add("password", "Password is required!");
            }

            if (string.IsNullOrEmpty(this.address))
            {
                errors.Add("address", "Address is required!");
            }

            if (string.IsNullOrEmpty(this.phone))
            {
           
                errors.Add("phone", "Phone is required!");
            } 
            
            if (string.IsNullOrEmpty(this.avatar))
            {
           
                errors.Add("avatar", "Avatar is required!");
            } 
            
            if (string.IsNullOrEmpty(this.email))
            {
           
                errors.Add("email", "Avatar is required!");
            }

            return errors;
        }

        public Dictionary<string, string> ValidateLogin()
        {
            var errors = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(this.email))
            {

                errors.Add("email", "Avatar is required!");
            }

            if (string.IsNullOrEmpty(this.password))
            {

                errors.Add("password", "Avatar is required!");
            }

            return errors;
        }

    }


}
