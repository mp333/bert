using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App2.Model
{
    //constructor
    class Customer
    {
        private string _password;
        private string _username;


        public Customer(string password, string username)
        {
            this._password = password;
            this._username = username;
         }

        public void Login()
        {

        }
    }
}

