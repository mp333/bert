using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using App10.Model;
using ViewModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App10.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        

        public BlankPage1()
        {
            this.InitializeComponent();
           
        }

        CustomerList ss = new CustomerList();

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void register_Click_1(object sender, RoutedEventArgs e)
        {
            
            ss.Username = textBox.Text;
            ss.Password = textBox1.Text;
            ss.Register();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            ss.Username2 = textBox3.Text;
            ss.Password2 = textBox4.Text;
            if (ss.CanLogin())
            {
                Frame.Navigate(typeof(MainPage));
            }
        }
        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
