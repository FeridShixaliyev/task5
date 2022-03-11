using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            


            car sale = new car
            {
                color="blue",
                name="mercedes-benz",
                brand="mercedes",
                model="g63 amg",
            };
            Console.WriteLine("color :"+sale.color+"   "+"name:"+sale.name+"   "+"brand:"+ sale.brand + "   " +"model:"+ sale.model) ;

        }
    }

    class vihicle
    {
        public string color;
        public string name;
    }

    class car:vihicle
    {
        public string brand;
        public string model;
    }
}
