using System;
using System.Collections.Generic;

namespace Exercise
{
    public abstract class Common
    {
        public string Name { get; }
        public string Email { get; set; }

        public virtual void GetIdentificationNumber()
        {
        }

    }

    public class Companies : Common
    {
        static List<Selling> selling_produts = new List<Selling>();
        private int NIPC { get; set; }

        public override void GetIdentificationNumber()
        {
            Console.WriteLine(NIPC);
        }

        public void Add_Buying_List(string name, decimal price, int quantity, decimal tax, string person)
        {
            selling_produts.Add(new Selling(name, price, quantity, tax, person));
        }
        public void See_List()
        {
            foreach (Selling b in selling_produts)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", b.Name, b.Unity_Price, b.Quantity, b.Tax, b.Person);
            }
        }
    }
    public class Persons : Common
    {
        static List<Buying> buying_produts = new List<Buying>();

        private int NIF { get; set; }

        public override void GetIdentificationNumber()
        {
            Console.WriteLine(NIF);
        }
        public void Add_Buying_List(string name, decimal price, int quantity, decimal tax, string company)
        {
            buying_produts.Add(new Buying(name, price, quantity, tax, company));
        }
        public void See_List()
        {
            foreach (Buying b in buying_produts)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", b.Name, b.Unity_Price, b.Quantity, b.Tax, b.Companny);
            }
        }
    }

    public abstract class Product
    {
        public Product() { }
        public string Name;
        public decimal Unity_Price;
        public int Quantity;
        public decimal Tax;
    }
    public class Selling : Product
    {
        public string Person;
        public Selling(string name, decimal price, int quantity, decimal tax, string person)
        {
            Name = name;
            Unity_Price = price;
            Quantity = quantity;
            Tax = tax;
            Person = person;
        }
    }
    public class Buying : Product
    {
        public string Companny;
        public Buying(string name, decimal price, int quantity, decimal tax, string company)
        {
            Name = name;
            Unity_Price = price;
            Quantity = quantity;
            Tax = tax;
            Companny = company;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Ruben Teles
        }
    }
}