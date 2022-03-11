using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            product phone = new product
            {
                Name = "Iphone 13 pro max",
                Brandname = "Apple",
                Price = 1200,
            };
            Console.WriteLine("Name: " + phone.Name + "  Brandname: " + phone.Brandname + "  Price: " + phone.Price);

            int[] Product = {1,2,3,4,5,6,7,8,9};
            int minp = 3;
            int maxp = 7;
            Interval(ref Product, minp, maxp);
            foreach (var item in newProduct)
            {
                Console.WriteLine(item);
            }

        }

        static int Interval(ref int []Product,int minp,int maxp)
        {
            int length = Product.Length;
            int[] newProduct = new int[length];//yeni array yatardim
            for (int i = 0; i < Product.Length; i++)
            {
                while(Product[i]>=minp && Product[i] <= maxp)
                {
                    newProduct[i]= Product[i];//ve sert odediyi muddetde elementleri yeni arraye yigmaga cehd etdim
                }

            }

            return newProduct;//ama burda nese sehf edirem bilmirem harda
        }
    }

    class product
    {
        public string Name;
        public string Brandname;
        public int Price;
    }
}
