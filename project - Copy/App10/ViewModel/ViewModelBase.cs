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
   public abstract class ViewModelBase : INotifyPropertyChanged  //this class sets the name of the last person who logged in as the current customer
    {
        private static Customer currentCustomer;

       public Customer CurrentCustomer
       {
           get { return currentCustomer; }
           set
           {
               currentCustomer = value;
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
