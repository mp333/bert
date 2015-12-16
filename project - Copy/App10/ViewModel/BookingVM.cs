using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.AppService;
using App10.Model;
using App10.Common;
using App10.Persistency;
using App10.ViewModel;
using Windows.UI.Popups;

namespace App10.ViewModel
{
    public class BookingVM : ViewModelBase
    {
        // properties
        // relaycommands and their methods
        // constructor for datacontext

        public ObservableCollection<Booking> Books { get; set; }

        public ObservableCollection<int> Numbers { get; set; }
        
        private DateTimeOffset czechin = new DateTimeOffset(DateTime.Today);
        public DateTimeOffset czechout = new DateTimeOffset(DateTime.Today);

        public DateTimeOffset CzechOut
        {
            get
            {
                return czechout;
            }
            set
            {
                czechout = value;
                OnPropertyChanged();
            }
        }
        public DateTimeOffset CzechIn
        {
            get
            {
                return czechin;
            }
            set { czechin = value;
                OnPropertyChanged(); }
        }
 //placeholder
        private bool isconfirmed;
        private bool isallinc;
        private int howmanyppl =1;
        private int cost;
        private int creditcard;
        private DateTime chekins;
        private DateTime chekaus;

        public DateTime ChekIns
        {
            get { return chekins; }
            set
            {
                chekins = value;
                OnPropertyChanged();
            }
        }

        public DateTime ChekAus
        {
            get { return chekaus; }
            set
            {
                chekaus = value;
                OnPropertyChanged();
            }
        }
        public int CreditCard
        {
            get { return creditcard; }
            set
            {
                creditcard = value;
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
            if (IsConfirmed && DateCalc() && DateCalc2() && HowManyPpl>-1 && CreditCard>0)
                return true;
            else
            {
                return false;
            }
        }


        public bool DateCalc()
        {
            ChekIns = CzechIn.DateTime;
            ChekAus = CzechOut.DateTime;   
            if (ChekIns < ChekAus && ChekIns > DateTime.Today)
                return true;
            else
                return false;
        }

        
        public bool DateCalc2()
        {
            ChekIns = CzechIn.DateTime;
            ChekAus = CzechOut.DateTime;
            int xx = 1;
            foreach (Booking book in Books)
            {
                
                if (book.CheckInDateTime < ChekAus.Date && ChekIns.Date < book.CheckOutDateTime)
                    xx++;
            }
            return xx < 2;
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
        {   HandleCommand = new RelayCommand(HandleEx);
            AddBookingCommand = new RelayCommand(AddBooking, CanConfirm);
            GetBookCommand = new RelayCommand(LoadMyBookings);
            
            Books = new ObservableCollection<Booking>();
            LoadBookings();
                  
        }
        public RelayCommand AddBookingCommand { get; set; }
        public RelayCommand GetBookCommand { get; set; }

   
        public RelayCommand HandleCommand { get; set; }
        public async void LoadBookings()
        {
            Books.Clear();
            
            var books = await PersistencyService.LoadBookingsFromJsonAsync();
            if (books != null)
            {

                foreach (var book in books)
                {
                    if (book.ThisAccomodation.Equals(CurrentAccomodation)) //    if(book.OrderedBy == CurrentCustomer.Name) place
                    {
                        Books.Add(book);
                    }
                }
            }
        }


        public void HandleEx()
        {
            if (DateCalc() && DateCalc2() && HowManyPpl + 1 > 0 && CreditCard > 0)
            {
                TimeSpan xx = CzechOut.Subtract(CzechIn);
                if (IsAllInc)
                {
                    Cost = CurrentAccomodation.Price * 2 * (HowManyPpl + 1) * xx.Days;
                }
                else if (IsAllInc != true)
                {
                    Cost = CurrentAccomodation.Price * (HowManyPpl + 1) * xx.Days;
                    
                }
                IsConfirmed = true;
            }
            else if(DateCalc2() == false)
            {
                IsConfirmed = false;
                MessageDialogHelper.Show(" Those Dates are already booked", "Invalid Dates");
            }
            else if (DateCalc() == false)
            {
                IsConfirmed = false;
                MessageDialogHelper.Show("Check in must be in the future, and earlier than check out", "Invalid Dates");
            }
            else if (HowManyPpl+1==0 || CreditCard >0 == false)
            {
                IsConfirmed = false;
                MessageDialogHelper.Show(" Please fill out your info", "Invalid Info");
            }
        }

        public void AddBooking()
        {

            Books.Add(new Booking(CurrentAccomodation, CzechIn.Date, CzechOut.Date, CurrentCustomer.Name, HowManyPpl+1));
            PersistencyService.SaveBookingsAsJsonAsync(Books);
            IsConfirmed = false;
            Success = 100;
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
