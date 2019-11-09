using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //public class Person
    //{
    //    public string Name;

    //    public void Introduce(string to)
    //    {
    //        Console.WriteLine("Hi {0}, I am {1}", to, Name);
    //        Console.ReadLine();
    //    }

    //    public static Person Parse(string str)
    //    {
    //        var person = new Person();
    //        person.Name = str;

    //        return person;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var person = Person.Parse("John");
    //        person.Introduce("Clark");
    //    }
    //}

    

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "John");

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.ReadLine();

        }

    }
}
