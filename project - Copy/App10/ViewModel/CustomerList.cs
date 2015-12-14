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
    public class CustomerList : ViewModelBase//login, register, customer datbabase view model
    {

        public string Username { get; set; }
  
        
        public string Password { get; set; }

        

     
        public ObservableCollection<Customer> List1 { get; set; }

        
        public CustomerList()
        {
            LoginCommand = new RelayCommand(Login, CanLogin);
            AddCustomerCommand = new RelayCommand(Register, CanRegister);
            GetListCommand = new RelayCommand(LoadCustomers);
            List1 = new ObservableCollection<Customer>();
            LoadCustomers(); 
        }

        private bool islogged;

        public bool IsLoggedIn
        {
            get { return islogged; }
            set
            {
                islogged = value;
                OnPropertyChanged();
            }
        }

        private bool ischecked;

        public bool IsChecked
        {
            get { return ischecked; }
            set
            {
                ischecked = value;
                OnPropertyChanged();
            }
        }

        public bool CanRegister()
        {
            return Username != null && Password != null;
        }

        private int success = 0;
        public int Success
        {
            get { return success; }

            set
            {
                success = value;
                OnPropertyChanged();
            }
        }
    

    private string username2;

        public string Username2
        {
            get { return username2; } //this?
            set
            {
                    username2 = value;
                    OnPropertyChanged("Username2");
                
            }
        }

        private string password2;

        public string Password2
        {
            get { return password2; }
            set
            {
                    password2 = value;
                    OnPropertyChanged("Password2");
                // works!
            }
        }

        public RelayCommand AddCustomerCommand { get; set; }
        public RelayCommand GetListCommand { get; set; }

        public RelayCommand LoginCommand { get; set; }

        public void Login()
        {
            Success = 100; //makesxwxwxrti button visible
            CurrentCustomer = new Customer(Username2,Password2);
            IsLoggedIn = true;
            
        }
        public void Register()
        {
             
           
            List1.Add(new Customer(Username, Password));
            PersistencyService.SaveCustomersAsJsonAsync(List1);

        }


        public async void LoadCustomers()
        {
            List1.Clear();
            List1.Add(new Customer("admin", "321"));
            var customers = await PersistencyService.LoadCustomersFromJsonAsync();
            foreach (var customer in customers)
            {
                List1.Add(customer);
            }
         
        }




        public bool CanLogin()
        {
            if (List1.Contains(new Customer(Username2, Password2)) && IsChecked )
            {
                return true;
            }
            else
                return false;
        }


    }
}
