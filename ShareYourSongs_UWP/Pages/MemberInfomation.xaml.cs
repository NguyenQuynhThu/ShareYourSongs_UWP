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
using ShareYourSongs_UWP.Services;
using ShareYourSongs_UWP.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ShareYourSongs_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MemberInfomation : Page
    {
        private MemberInfomationService _memberInfomationService = new MemberInfomationService();

        public MemberInfomation()
        {
            this.InitializeComponent();
            LoadMemberInformation();
          
        }

        private async void LoadMemberInformation()
        {
            if (string.IsNullOrEmpty(Login.Token))
            {
                var fileName = "tokenFile";
                var result = await FileHandleService.ReadFile(fileName);
                if (!string.IsNullOrEmpty(result))
                {
                    Login.Token = result;
                }
            }
            Member member = await this._memberInfomationService.GetMemberInformation(Login.Token);

            try
            {
                FirstName.Text = member.firstName;
                LastName.Text = member.lastName;
                Address.Text = member.address;
                Phone.Text = member.phone;
                switch (member.gender)
                {
                    case 1:
                        Gender.Text = "Male";
                        break;
                    case 0:
                        Gender.Text = "Female";
                        break;
                    case 2:
                        Gender.Text = "Other";
                        break;
                }
                Email.Text = member.email;
                Birthday.Text = member.birthday;
            }
            catch (Exception)
            {
                this.Frame.Navigate(typeof(Pages.Login));
            }

            
        }
    }
}
