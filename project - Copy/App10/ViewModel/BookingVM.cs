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
    public class BookingVM : ViewModelBase
    {
        // properties
        // relaycommands and their methods
        // constructor for datacontext

        public ObservableCollection<Booking> Books { get; set; }

        public ObservableCollection<int> Numbers { get; set; } 

        private DateTime czechin;
        private DateTime czechout;
        private TimeSpan dayspan; //placeholder
        private bool isconfirmed;
        private bool isallinc;
        private int howmanyppl;
        private int cost;
        private int creditcard;

        public int CreditCard
        {
            get { return creditcard; }
            set
            {
                creditcard = value;
                OnPropertyChanged();
            }
        }

        public DateTime CzechzIn
        {
            get
            {
                return czechin;
            }
            set
            {
                czechin = value;
                OnPropertyChanged();
            }
        }

        public DateTime CzechOut
        {
            get { return czechout; }
            set
            {
                czechout = value;
                OnPropertyChanged();
            }
        }

        public TimeSpan DaySpan
        {
            get { return dayspan; }
            set
            {
                DaySpan = value;
                OnPropertyChanged();
            }

        } 

        public bool IsConfirmed
        {
            get
            {
                return isconfirmed;
            }
            set
            {
                isconfirmed = value;
                OnPropertyChanged();
            }
        }

        public bool IsAllInc
        {
            get { return isallinc;}
            set
            {
                isallinc = value;
                OnPropertyChanged();
            }
        }

        public int HowManyPpl
        {
            get { return howmanyppl;}
            set
            {
                howmanyppl = value;
                OnPropertyChanged();
            }
        }

        public int Cost
        {
            get { return cost; }
            set
            {
                cost = value;
                OnPropertyChanged();
            }
        }

        private int success;

        public int Success
        {
            get { return success; }
            set
            {
                success = value;
                OnPropertyChanged();
            }
        }

        public bool CanConfirm()
        {
            if (IsConfirmed)// && CreditCard>999 && Creditcard <10000 && HowManyPpl > 0 etc
                return true;
            else
                return false;
        }


        public async void LoadMyBookings()
        {

            Books.Clear();
            Success = 100;
            var books = await PersistencyService.LoadBookingsFromJsonAsync();
            if (books != null)
            {

                foreach (var book in books)
                {
                    if(book.OrderedBy == CurrentCustomer.Name) // filters only the bookings made by the logged in customer
                    Books.Add(book);
                }
            }

        }
        public BookingVM()
        {
            AddBookingCommand = new RelayCommand(AddBooking, CanConfirm);
            GetBookCommand = new RelayCommand(LoadMyBookings);
            Books = new ObservableCollection<Booking>();
            LoadBookings();
                  
        }
        public RelayCommand AddBookingCommand { get; set; }
        public RelayCommand GetBookCommand { get; set; }

        public async void LoadBookings()
        {
            Books.Clear();
            
            var books = await PersistencyService.LoadBookingsFromJsonAsync();
            if (books != null)
            {

                foreach (var book in books)
                {
  
                    Books.Add(book);
                }
            }
        }


        public void AddBooking()
        {

            Books.Add(new Booking(CzechzIn, CzechOut, CurrentCustomer.Name, HowManyPpl+1));
            PersistencyService.SaveBookingsAsJsonAsync(Books);
        }

    }
}
