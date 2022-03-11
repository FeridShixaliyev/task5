using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            product phone = new product
            {
                Name="Iphone 13 pro max",
                Brandname="Apple",
                Price=1200,
            };
            Console.WriteLine("Name: "+phone.Name+"  Brandname: "+ phone.Brandname+"  Price: "+ phone.Price);
        }
    }

    class product
    {
        public string Name;
        public string Brandname;
        public int Price;
    }
}
