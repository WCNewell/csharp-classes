using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }
        
        // vv Technically these are redundant to the above code and don't 
        public Customer(int id)
            :this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
    }
}
