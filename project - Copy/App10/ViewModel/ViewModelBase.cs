using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App10.Model;

namespace App10.ViewModel
{
   public abstract class ViewModelBase : INotifyPropertyChanged 
    {
       private static Customer currentCustomer;
       private static Accomodation currentAccomodation;
       public Customer CurrentCustomer     //this class sets a Customer object of the last person who logged in as the current customer
        {
           get { return currentCustomer; }
           set
           {
               currentCustomer = value;
               OnPropertyChanged();
           }
       }

       public Accomodation CurrentAccomodation  // this one sets the current accomodation object to the last selected accomodation
       {
           get { return currentAccomodation; }
           set
           {
               currentAccomodation = value;
               OnPropertyChanged();
           }
           
       }

       public event PropertyChangedEventHandler PropertyChanged;



        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;


            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    }
