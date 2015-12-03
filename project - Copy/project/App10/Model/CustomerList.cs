using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Model
{
    class CustomerList
    {
       private string x; //username and password connected by magic to textboxes
      private string y;

       private List<Customer> list;

        public string Username
        {
            get { return x; }
            set { x = value; }
        }

        public string Password
        {
            get { return y; }
            set { y = value; }
        }

        public CustomerList()
        {
            list = new List<Customer>();
        }

        public void Register()
        {   
            list.Add(new Customer(x, y));
            x = null;
            y = null;
        }

    }
}
