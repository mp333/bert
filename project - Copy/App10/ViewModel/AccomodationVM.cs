using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App10.Common;
using App10.Model;

namespace App10.ViewModel
{
   public class AccomodationVM : ViewModelBase
   {
       private int success;

       public int Success
       {
           get { return success;}
           set
           {
               success = value;
               OnPropertyChanged();
           }
       }
        public ObservableCollection<Accomodation> Accomodations { get; set; }
        public AccomodationVM()
       {
            LyonCommand = new RelayCommand(SetLyon);
            Accomodations = new ObservableCollection<Accomodation>();


        }
        public RelayCommand LyonCommand { get; set; }

       private bool canbook;

       public bool CanBook
       {
           get { return canbook; }
           set
           {
               canbook = value;
               OnPropertyChanged();
           }
       }

       public void SetLyon()
       {
           CurrentAccomodation = new Accomodation("Lyon",300);
           Success = 100;
           CanBook = true;
       }
    }
}
