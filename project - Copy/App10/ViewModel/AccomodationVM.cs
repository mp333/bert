using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using App10.Common;
using App10.Model;
using Windows.Storage.Streams;

namespace App10.ViewModel
{
   public class AccomodationVM : ViewModelBase
   {
       private int success;
       private string descrip;

       public string Description
       {
           get { return descrip; }
           set
           {
               descrip = value;
               OnPropertyChanged();
           }
       }
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
            Accomodation1 = new RelayCommand(SetOne);
            Accomodation3 = new RelayCommand(SetThree);
            Accomodation4 = new RelayCommand(SetFour);
            Accomodation5 = new RelayCommand(SetFive);
            Accomodation6 = new RelayCommand(SetSix);
            Accomodation7 = new RelayCommand(SetSeven);
            Accomodation8 = new RelayCommand(SetEight);
            Accomodation9 = new RelayCommand(SetNein);
            Accomodation10 = new RelayCommand(SetTen);
            Accomodation11 = new RelayCommand(SetElv);
            Accomodation12 = new RelayCommand(SetTwelve);
            Accomodation2 = new RelayCommand(SetTwo);

        }
        public RelayCommand Accomodation1 { get; set; }
        public RelayCommand Accomodation2 { get; set; }
        public RelayCommand Accomodation3 { get; set; }
        public RelayCommand Accomodation4 { get; set; }
        public RelayCommand Accomodation5 { get; set; }
        public RelayCommand Accomodation6 { get; set; }
        public RelayCommand Accomodation7 { get; set; }
        public RelayCommand Accomodation8 { get; set; }
        public RelayCommand Accomodation9 { get; set; }

        public RelayCommand Accomodation10 { get; set; }

        public RelayCommand Accomodation11 { get; set; }

        public RelayCommand Accomodation12 { get; set; }
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

    
       private string iurl;

       public string ImageUrl
       {
           get { return iurl; }
           set
           {
               iurl = value;
               OnPropertyChanged();
           }
       }

       public void SetOne()
       {
           CurrentAccomodation = new Accomodation("Lyon",300);
           Success = 100;
           CanBook = true;
           Description = "This stunning very private and quiet Provençal-style 4 bedroomed designer villa offers an area of tropical privacy, whilst enjoying a magnificent panoramic sea view from Monaco to Menton. The wood deck gives the impression of literally being able to dive into the deep blue Mediterranean sea.";
           ImageUrl = " ../Assets/haus.jpg";
       }
        public void SetTwo()
        {
            CurrentAccomodation = new Accomodation("L'Escapede", 200);
            Success = 100;
            CanBook = true;
            Description = "L'Escapade offers a very high standard of accommodation throughout the year with the benefit of full central heating in the winter months. The ground floor of the property has a generous dining area with double bedroom and bathroom next door. Rooms include wifi.";
            ImageUrl = " ../Assets/apt.jpg";
        }
        public void SetThree()
        {
            CurrentAccomodation = new Accomodation("Les Carres", 150);
            Success = 100;
            CanBook = true;
            Description = " The first floor has a large lounge area with west views to the countryside and magnificent sunsets, there are two further bedrooms 1 double with en suite and 1 twin bedded with bathroom adjacent. The entire barn exudes a feeling of quality and attention to detail.";
            ImageUrl = " ../Assets/view.jpg";
        }

        public void SetFour()
        {
            CurrentAccomodation = new Accomodation("Felicci", 350);
            Success = 100;
            CanBook = true;
            Description = " This 17th Century Chateau is a beautiful place to stay. The friendly staff create a relaxed atmosphere where you can unwind and leave all those boring daily chores behind and let others do the work! Wonderful place to bring family or friends or perhaps celebrate a wedding or anniversary. ";
            ImageUrl = " ../Assets/bed.jpg";
        }

        public void SetFive()
        {
            CurrentAccomodation = new Accomodation("Rene's", 270);
            Success = 100;
            CanBook = true;
            Description = "  There is a large trampoline, numerous swings, slide, undercover table tennis, badminton etc to be found within the beautiful mature floral gardens to amuse children and adults alike.";
            ImageUrl = " ../Assets/9.jpg";
        }

        public void SetSix()
        {
            CurrentAccomodation = new Accomodation("au Madette", 135);
            Success = 100;
            CanBook = true;
            Description = "The apartment's layout and its size (75 square meter/800 square foot) will provide you with ample space to relax and to enjoy your own privacy. Ideally suited for two couples or a family with children, the two bedrooms sleep 4 guests comfortably. ";
            ImageUrl = " ../Assets/ap.jpg";
        }

        public void SetEight()
        {
            CurrentAccomodation = new Accomodation("FonFon", 160);
            Success = 100;
            CanBook = true;
            Description = "The property is fully fenced and there are pool toys, many bikes, children's toys and books, a tree house and the 12th century grange (one of the village's oldest buildings) has a pool table, dart board and table football. ";
            ImageUrl = " ../Assets/pool.jpg";
        }

        public void SetSeven()
        {
            CurrentAccomodation = new Accomodation("Giverny", 195);
            Success = 100;
            CanBook = true;
            Description = " This penthouse is located on the top-floor apartment on 7th floor with a stunning, uninterrupted panoramic views over the sea and old Antibes, extending from the Alpes in the North, over the old fort and ports, to the Cap d'Antibes in the South. The view will give you a taste of what old Antibes has to offer. ";
            ImageUrl = " ../Assets/2.jpg";
        }

        public void SetNein()
        {
            CurrentAccomodation = new Accomodation("Frog", 230);
            Success = 100;
            CanBook = true;
            Description = " This spacious property includes the professionally interior decorated 4 bedroom house Les Roses and 2 bedroom cottage La Lavande. Enjoy relaxing in the gardens full of fruit trees and roses, swim in the heated pool, step outside the gates into the charming village";
            ImageUrl = " ../Assets/add.jpg";
        }

        public void SetTen()
        {
            CurrentAccomodation = new Accomodation("Au Anatelle", 225);
            Success = 100;
            CanBook = true;
            Description = "The beautifully renovated 18th century house has 4 bedrooms, 4 bathrooms, large terrace, private garden in which there is a 8x4.5m swimming pool. From the house and terrace there are wonderful views of unfenced rolling hills of woods.";
            ImageUrl = " ../Assets/view2.jpg";
        }

        public void SetElv()
        {
            CurrentAccomodation = new Accomodation("Omlette du fromage", 320);
            Success = 100;
            CanBook = true;
            ImageUrl = " ../Assets/vila.jpg";
            Description = "This Italianate villa was built in 2011 with modern references to traditional Provençal architecture using natural stone-clad exterior walls and traditional terracotta roof tiles. ";
        }

        public void SetTwelve()
        {
            CurrentAccomodation = new Accomodation("Le Putin", 420);
            Success = 100;
            CanBook = true;
            Description = " The 5 stylish ensuite bedrooms with walk in closets each have a balcony overlooking the fantastic sweeping gardens and 18mx 4.30 heated pool, with a fully equipped pool house housing an outdoor kitchen and pizza oven. ";
            ImageUrl = " ../Assets/bed.jpg";
        }
    }
}
