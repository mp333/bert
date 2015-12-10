using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Model
{
   public class Booking
    {
        private DateTime checkinDateTime;
        private DateTime checkoutDateTime;
        private DateTime orderDateTime;
        private int orderID;

        private static int c = 1;

        public Accomodation ThisAccomodation;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public DateTime CheckInDateTime
        {
            get { return checkinDateTime; }
            set { checkinDateTime = value; }
        }

        public DateTime CheckOutDateTime
        {
            get { return checkoutDateTime;}
            set { checkoutDateTime = value; }
        }

        public DateTime OrderDateTime
        {
            get { return orderDateTime;}
            set { orderDateTime = value; }
        }

        public Booking(DateTime checkin, DateTime checkout, Accomodation thisacc)
        {
            CheckInDateTime = checkin;
            CheckOutDateTime = checkout;
            orderDateTime = DateTime.Now;
            orderID = c++;
        }

    }
}
