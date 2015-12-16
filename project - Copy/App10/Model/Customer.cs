using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App10.ViewModel;


    namespace App10.Model
    {
    public class Customer
    {  
        //ID = count++, Bookings
        public string Name { get; set; }
        public string Pass { get; set; }

        public string ContactInfo { get; set; }

        public Customer(string username, string password)
        {
            Name = username;
            Pass = password;

            ContactInfo = "blabla contact info";
        }

        public override string ToString()
        {
            return string.Format("Logged in as {0} ",Name);
        }

        public bool Equals(Customer other)
        {
            if (other == null)
                return false;

            return this.Name == other.Name &&
            this.Pass == other.Pass;
        }
        // all this shit is to override the List.Contains()
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Customer customerObj = obj as Customer;
            if (customerObj == null)
                return false;
            else
                return Equals(customerObj);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public static bool operator ==(Customer person1, Customer person2)
        {
            if (((object)person1) == null || ((object)person2) == null)
                return Object.Equals(person1, person2);

            return person1.Equals(person2);
        }

        public static bool operator !=(Customer person1, Customer person2)
        {
            return !(person1 == person2);
        }
    }

    public interface IEquateable<T>
    {
    }
}
