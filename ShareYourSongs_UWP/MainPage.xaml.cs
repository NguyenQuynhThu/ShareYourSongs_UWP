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
using ShareYourSongs_UWP.Pages;
using ShareYourSongs_UWP.Services;
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ShareYourSongs_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            CheckSession();
        }
        private async void CheckSession()
        {
            var fileName = "tokenFile";
            var result = await FileHandleService.ReadFile(fileName);
            if (!string.IsNullOrEmpty(result))
            {
                contentFrame.Navigate(typeof(MemberInfomation),null);

            }
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(Login), null);
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(Register), null);
        }

        private void Upload_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(AddSong), null);
        }

        private void ListSongs_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(ListSongs), null);
        }

        private void My_ListSongs_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(ListSongs), null);
        }
        
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(MemberInfomation), null);
        }

    }
}
