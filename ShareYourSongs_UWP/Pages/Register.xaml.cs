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
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Diagnostics;
using ShareYourSongs_UWP.Services;
using SQLitePCL;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ShareYourSongs_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {
        private IMemberService _service;
        private int _gender;

        public Register()
        {
            this.InitializeComponent();
            this._service = new MemberService();

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                string choice = radioButton.Tag.ToString();
                switch (choice)
                {
                    case "Male":
                        this._gender = 1;
                        break;
                    case "Female":
                        this._gender = 0;
                        break;
                    case "Other":
                        this._gender = 2;
                        break;
                }
            }
        }

        private async void SubmitData(object sender, RoutedEventArgs e)
        {

            var member = new Member()
            {
                firstName = TxtFirstName.Text,
                lastName = TxtLastName.Text,
                password = PwdPassword.Password,
                address = TxtAddress.Text,
                phone = TxtPhone.Text,
                avatar = TxtAvatar.Text,
                gender = _gender,
                email = TxtEmail.Text,
                birthday = DatePickerBirthday.SelectedDate.Value.DateTime.ToString("yyyy-MM-dd")
            };

            var errors = member.ValidateRegister();

            if (errors.Count > 0)
            {
                HandleError(errors);
            }
            else
            {
                var result = await this._service.Create(member);
                if (result.id > 0)
                {
                    Frame frame = Window.Current.Content as Frame;
                    frame.Navigate(typeof(Login));
                }
            
            }

        }
        private void HandleError(Dictionary<string, string> errors)
        {
            if (errors.ContainsKey("firstName"))
            {
                FirstName_Error.Text = errors["firstName"];
            }
            
            if (errors.ContainsKey("lastName"))
            {
                LastName_Error.Text = errors["lastName"];
            }
            
            if (errors.ContainsKey("password"))
            {
                Password_Error.Text = errors["password"];
            }
            
            if (errors.ContainsKey("address"))
            {
                Address_Error.Text = errors["address"];
            }
            
            if (errors.ContainsKey("phone"))
            {
                Phone_Error.Text = errors["phone"];
            }
            
            if (errors.ContainsKey("avatar"))
            {
                Avatar_Error.Text = errors["avatar"];
            }
            
            if (errors.ContainsKey("email"))
            {
                Email_Error.Text = errors["email"];
            }
            
        }

    }
    
}
