using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App10.ViewModel;

namespace App10.Model
{
    public class Booking
    {



        public string OrderedBy { get; set; }

        public DateTime CheckInDateTime { get; set; }

        public DateTime CheckOutDateTime { get; set; }
        public DateTime OrderDateTime { get; set; }
        private static int c = 1;
        public int NumberOfPpl { get; set; }

        public int BookNumber { get; set; }
        public Booking(DateTime checkin, DateTime checkout, string ordered, int ppl)
        {
            BookNumber = c++; // not using
            CheckInDateTime = checkin;
            CheckOutDateTime = checkout;
            OrderDateTime = DateTime.Now;
            OrderedBy = ordered; //placeholder
            NumberOfPpl = ppl;
            
        }

        public override string ToString()
        {
            return string.Format("Number: {0}, Booked by: {1}, For {2} people, Booked on: {3}, From {4} to {5} ", BookNumber, OrderedBy, NumberOfPpl, OrderDateTime, CheckInDateTime, CheckOutDateTime);
        }// in accom x
    }
}
