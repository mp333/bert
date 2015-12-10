using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Model
{
   public class Customer
    {
        public string Name { get; set; }
        public string Pass { get; set; }

        public Customer(string username, string password = "")
        {
            Name = username;
            Pass = password;
        }

        public bool Equals(Customer other)
        {
            if (other == null)
                return false;

            return this.Name == other.Name &&
            this.Pass == other.Pass;
        }

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
