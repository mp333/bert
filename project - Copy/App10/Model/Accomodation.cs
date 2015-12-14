using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Model
{
   public class Accomodation
    {   
        public string Adress { get; set; }
        public int Price { get; set; }

        public string AccName { get; set; }
        public Accomodation(string acname,int price)
        {
            AccName = acname;
            Adress = "go here: blabla";
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0}",AccName);
        }// in accom x

       
        //etc.
    }
}
