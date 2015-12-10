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

        public static async void SaveNotesAsJsonAsync(ObservableCollection<Customer> list)
        {
            string notesJsonString = JsonConvert.SerializeObject(list);
            SerializeNotesFileAsync(notesJsonString, JsonFileName);
        }

        public static async Task<List<Customer>> LoadNotesFromJsonAsync()
        {
            string notesJsonString = await DeserializeNotesFileAsync(JsonFileName);
            if (notesJsonString != null)
            {
                return (List<Customer>)JsonConvert.DeserializeObject(notesJsonString, typeof(List<Customer>));
            }
            return null;
        }

        private static async void SerializeNotesFileAsync(string notesJsonString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, notesJsonString);
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
               
                return null;
            }
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
