using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Model
{
    class Accomodation
    {   
        public int Adress { get; set; }
        public int Price { get; set; }

        public Accomodation(int adress, int price)
        {
            Adress = adress;
            Price = price;
        }

        Accomodation _lyon = new Accomodation(12313, 600);
        //etc.
    }
}
