﻿#pragma checksum "C:\Users\ikutaoki\source\repos\ShareYourSongs_UWP\ShareYourSongs_UWP\Pages\Register.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AE02783EC4E72C09F3C46E032458D3ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShareYourSongs_UWP.Pages
{
    partial class Register : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\Register.xaml line 49
                {
                    this.TxtFirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Pages\Register.xaml line 50
                {
                    this.TxtLastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Pages\Register.xaml line 51
                {
                    this.PwdPassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 5: // Pages\Register.xaml line 52
                {
                    this.TxtAddress = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Pages\Register.xaml line 53
                {
                    this.TxtPhone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Pages\Register.xaml line 54
                {
                    this.TxtAvatar = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Pages\Register.xaml line 60
                {
                    this.TxtEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // Pages\Register.xaml line 61
                {
                    this.DatePickerBirthday = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 10: // Pages\Register.xaml line 63
                {
                    this.FirstName_Error = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Pages\Register.xaml line 64
                {
                    this.LastName_Error = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Pages\Register.xaml line 65
                {
                    this.Password_Error = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Pages\Register.xaml line 66
                {
                    this.Address_Error = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Pages\Register.xaml line 67
                {
                    this.Phone_Error = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Pages\Register.xaml line 68
                {
                    this.Avatar_Error = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // Pages\Register.xaml line 69
                {
                    this.Email_Error = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Pages\Register.xaml line 70
                {
                    this.Birthday_Error = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // Pages\Register.xaml line 72
                {
                    global::Windows.UI.Xaml.Controls.Button element18 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element18).Click += this.SubmitData;
                }
                break;
            case 19: // Pages\Register.xaml line 56
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element19 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element19).Checked += this.RadioButton_Checked;
                }
                break;
            case 20: // Pages\Register.xaml line 57
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element20 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element20).Checked += this.RadioButton_Checked;
                }
                break;
            case 21: // Pages\Register.xaml line 58
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element21 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element21).Checked += this.RadioButton_Checked;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

