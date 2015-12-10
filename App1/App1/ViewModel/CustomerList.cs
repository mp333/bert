using App1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModel
{
   public class CustomerList
    {
       public List<Customer> List = new List<Customer>();

        public string Username { get; set; }
        public string Password { get; set; }

        public string Username2 { get; set; }

        public string Password2 { get; set; }

        public void Register()
        {
            List.Add(new Customer(Username, Password));
        }

        public bool CanLogin()
        {
            return List.Contains(new Customer(Username2, Password2));
        }
    }
}

