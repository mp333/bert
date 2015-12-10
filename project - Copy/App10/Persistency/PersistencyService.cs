using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using App10.Model;
using Newtonsoft.Json;

namespace App10.Persistency
{
    

    // THIS is what makes the program remember after its closed

    class PersistencyService
    {
        private static string JsonFileName = "CustomersAsJson.dat";
        private static string JsonFileName2 = "BookingsAsJson.dat";
        public static async void SaveCustomersAsJsonAsync(ObservableCollection<Customer> list) //customers
        {
            string customersJsonString = JsonConvert.SerializeObject(list);
            SerializeNotesFileAsync(customersJsonString, JsonFileName);
        }

        public static async Task<List<Customer>> LoadCustomersFromJsonAsync()
        {
            string customersJsonString = await DeserializeNotesFileAsync(JsonFileName);
            if (customersJsonString != null)
            {
                return (List<Customer>)JsonConvert.DeserializeObject(customersJsonString, typeof(List<Customer>));
            }
            return null;
        }

        private static async void SerializeNotesFileAsync(string notsJsonString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, notsJsonString);
        }


        private static async Task<string> DeserializeNotesFileAsync(string fileName)
        {
            try
            {
                StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return await FileIO.ReadTextAsync(localFile);
            }
            catch (FileNotFoundException ex)
            {
                MessageDialogHelper.Show("You have nothing booked", "File not Found");
                return null;
            }
        }

        public static async void SaveBookingsAsJsonAsync(ObservableCollection<Booking> list2) //Booking
        {
            string booksJsonString = JsonConvert.SerializeObject(list2);
            SerializeNotesFileAsync(booksJsonString, JsonFileName2);
        }

        public static async Task<List<Booking>> LoadBookingsFromJsonAsync()
        {
            string customersJsonString = await DeserializeNotesFileAsync(JsonFileName2);
            if (customersJsonString != null)
            {
                return (List<Booking>)JsonConvert.DeserializeObject(customersJsonString, typeof(List<Booking>));
            }
            return null;
        }

        private class MessageDialogHelper
        {
            public static async void Show(string content, string title)
            {
                MessageDialog messageDialog = new MessageDialog(content, title);
                await messageDialog.ShowAsync();
            }
        }

    }
}
