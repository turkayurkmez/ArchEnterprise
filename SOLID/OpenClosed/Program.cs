using System;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir nesne gelişime AÇIK değişime KAPALI olmalıdır.
            //Yeni bir özellik eklemek istediğinizde, değişim yerine geliştirmek.
            Customer customer = new Customer { Cart = new Premium() };
            OrderManagement orderManagement = new OrderManagement();
            orderManagement.Customer = customer;
            var realPrice = orderManagement.GetRealPrice(1000);
            Console.WriteLine(realPrice.ToString());


            FileStream fileStream = new FileStream("yok.html", FileMode.CreateNew);
            //MemoryStream memoryStream = new MemoryStream()
            //NetworkStream networkStream = new NetworkStream()

            GZipStream stream = new GZipStream(fileStream, CompressionLevel.Optimal);
            CryptoStream cryptoStream = new CryptoStream(stream, null, CryptoStreamMode.Write);
        }


    }

    public abstract class CartType
    {
        //Standard, 
        //Silver,
        //Gold,
        //Premium
        public abstract decimal GetDiscountedPrice(decimal price);

    }

    public class Standard : CartType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .95m;
        }
    }
    public class Silver : CartType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .90m;
        }
    }

    public class Gold : CartType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .85m;
        }
    }

    public class Premium : CartType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .80m;
        }
    }

    public class Customer
    {
        public CartType Cart { get; set; }

    }

    public class OrderManagement
    {
        public Customer Customer { get; set; }
        public decimal GetRealPrice(decimal price)
        {
            return Customer.Cart.GetDiscountedPrice(price);
            //switch (Customer.Cart)
            //{
            //    case CartType.Standard:
            //        return price * 0.95M;
            //    case CartType.Silver:
            //        return price * 0.90M;
            //    case CartType.Gold:
            //        return price * 0.85M;
            //    case CartType.Premium:
            //        return price * 0.85M;
            //    default:
            //        return price;                  
            //}
        }
    }
}

