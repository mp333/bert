﻿#pragma checksum "C:\Users\pc\Documents\GitHubVisualStudio\bert\project - Copy\App10\View\BlankPage1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F1E5119ACAD2FEB7DBAA072C0FD17437"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App10.View
{
    partial class BlankPage1 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Login = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 2:
                {
                    this.Register = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 3:
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 37 "..\..\..\View\BlankPage1.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.textBox).TextChanged += this.textBox_TextChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.textBox1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 38 "..\..\..\View\BlankPage1.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.textBox1).TextChanged += this.textBox1_TextChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.textBox3 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 39 "..\..\..\View\BlankPage1.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.textBox3).TextChanged += this.textBox3_TextChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.textBox4 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 40 "..\..\..\View\BlankPage1.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.textBox4).TextChanged += this.textBox4_TextChanged;
                    #line default
                }
                break;
            case 7:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 41 "..\..\..\View\BlankPage1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.checkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 9:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

