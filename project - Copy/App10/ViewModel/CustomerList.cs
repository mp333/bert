using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App10.Model;


namespace ViewModel

{
      public class CustomerList
    {
        public List<Customer> _list = new List<Customer>();

       public string Username { get; set; }
       public string Password { get; set; }

       public string Username2 { get; set; }
       
        public string Password2 { get; set; }

        public void Register()
        {
            _list.Add(new Customer(Username, Password));
        }

        public bool CanLogin()
        {
            return _list.Contains(new Customer(Username2,Password2 ));
        }
    }

}


