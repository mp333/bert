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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App10.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }



        private void city0_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (City1));
        }

        private void city1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (City2));
        }

        private void city4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (City3));
        }

        private void city5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (City4));
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (BlankPage1));
        }
    }
}
