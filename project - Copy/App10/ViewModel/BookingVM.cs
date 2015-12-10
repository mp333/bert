using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App10.Model;
using App10.Common;
using App10.Persistency;
using App10.ViewModel;

namespace App10.ViewModel
{
    public class BookingVM : INotifyPropertyChanged
    {
        // properties
        // relaycommands and their methods
        // constructor for datacontext

        public ObservableCollection<Booking> Books { get; set; }

        public BookingVM()
        {
            AddBookingCommand = new RelayCommand(AddBooking);
            GetBookCommand = new RelayCommand(LoadBookings);
            Books = new ObservableCollection<Booking>();
            //LoadBookings();
            
        }
        public RelayCommand AddBookingCommand { get; set; }
        public RelayCommand GetBookCommand { get; set; }

        public async void LoadBookings()
        {
            Books.Clear();
            var books = await PersistencyService.LoadBookingsFromJsonAsync();
            foreach (var book in books)
            {
                Books.Add(book);
            }

        }
        public void AddBooking()
        {

         //   Books.Add(new Booking());
            PersistencyService.SaveBookingsAsJsonAsync(Books);
        }

        private static string currentCustomer2;
        /// <summary>
        /// idk wtf 2 datacontext
        
        /// </summary>
        public string CurrentCustomer2
        {
            get { return currentCustomer2; }
            set { currentCustomer2 = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;


            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
