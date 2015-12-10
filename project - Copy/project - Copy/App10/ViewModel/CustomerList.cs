using App10.Common;
using App10.Model;
using App10.Persistency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using System.Runtime.CompilerServices;

namespace App10.ViewModel
{
    public class CustomerList : INotifyPropertyChanged
    {
        private string _password; // for INotifyPropertyChanged
        private string _username;//~
        public string Username { get; set; }
        public string Password { get; set; }

        public string CurrentCustomer { get; set; } //placeholder
        public ObservableCollection<Customer> List1 { get; set; } 
        public List<Customer> List2 { get; set; }

        public CustomerList()
        {   
            LoginCommand = new RelayCommand(Login, CanLogin);
            AddCustomerCommand = new RelayCommand(Register, CanRegister);
            GetListCommand = new RelayCommand(LoadCustomers);
            List1 = new ObservableCollection<Customer>();
           // LoadCustomers();  // < remove the //s to make the login work
            //the line is bugging out the Blankpage1 designer for some reason but it works good otherwise
        }

        public bool CanRegister()
        {
            return Username != null && Password != null;
        }
        public string Success { get; set; }

        private string username2;

        public string Username2
        {
            get { return username2; } //this?
            set
            {
                    username2 = value;
                    //OnPropertyChanged("Username2");
                
            }
        }

        private string password2;

        public string Password2
        {
            get { return password2; }
            set
            {
                    password2 = value;
                    //OnPropertyChanged("Password2");
                
            }
        }

        private ICommand m_ButtonCommand;


        public ICommand ButtonCommand
        {
            get { return m_ButtonCommand; }
            set { m_ButtonCommand = value; }
        }
        public RelayCommand AddCustomerCommand { get; set; }
        public RelayCommand GetListCommand { get; set; }

        public RelayCommand LoginCommand { get; set; }

        public void Login()
        {
            List1.Clear(); //placeholder for test
            CurrentCustomer = Username2; // this is the wannabe login
            //Here we put some way to move the page, or ot show the login is a success
        }
        public void Register()
        {
           
            List1.Add(new Customer(Username, Password));
            PersistencyService.SaveNotesAsJsonAsync(List1);
        }


        public async void LoadCustomers()
        {
            List1.Clear();
            List1.Add(new Customer("admin", "321"));
            var customers = await PersistencyService.LoadNotesFromJsonAsync();
            foreach (var customer in customers)
            {
                List1.Add(customer);
            }
         
        }

        public bool CanLogin()
        {
            return List1.Contains(new Customer(Username2, Password2));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        // im so hhigh
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) //what
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
