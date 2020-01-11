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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ShareYourSongs_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private AuthenticationService _service = new AuthenticationService();
        public static string Token;

        private async void SubmitData(object sender, RoutedEventArgs e)
        {
            try
            {
                var memberLogin = new Member()
                {
                    email = TxtEmail.Text,
                    password = PwdPassword.Password,

                };

                var errors = memberLogin.ValidateLogin();

                if (errors.Count > 0)
                {
                    HandleError(errors);
                }
                else
                {
                    var Token = await this._service.LoginTask(memberLogin);
                    if (Token != null)
                    {
                        FileHandleService.WriteToFile("tokenFile", Token);
                        Frame frame = Window.Current.Content as Frame;
                        frame.Navigate(typeof(MemberInfomation));

                    }
                    else
                    {
                        Email_Error.Text = "Email or password is incorrect!";
                    }

                }
            }
            catch (Exception)
            {
                throw new System.InvalidOperationException();

            }


        }
        private void HandleError(Dictionary<string, string> errors)
        {
            if (errors.ContainsKey("email"))
            {
                Email_Error.Text = errors["email"];
            }

            if (errors.ContainsKey("password"))
            {
                Password_Error.Text = errors["password"];
            }

        }




    }
}
