using System;
using System.Runtime.CompilerServices;

namespace StrategyPattern
{
    class Program
    {
        static void Main()
        {
            //var shoppingMall1 = new ShoppingMall(new HighDiscountStrategy())
            //{
            //    CustomerName = "MohammadHossein",
            //    BillAmount = 100
            //};
            //Console.WriteLine($"Final Bill : {shoppingMall1.GetFinalBill()}");

            //var shoppingMall2 = new ShoppingMall(new LowDiscountStrategy())
            //{
            //    CustomerName = "Karim",
            //    BillAmount = 200
            //};
            //Console.WriteLine($"Final Bill : {shoppingMall2.GetFinalBill()}");

            //var shoppingMall3 = new ShoppingMall(new NoDiscountStrategy())
            //{
            //    CustomerName = "salam",
            //    BillAmount = 300
            //};
            //Console.WriteLine($"Final Bill : {shoppingMall3.GetFinalBill()}");


            var shopping = new ShoppingMall()
            {
                CustomerName = "Mohammad",
                BillAmount = 10500
            };
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    shopping.Strategy = new HighDiscountStrategy();
                    break;
                case DayOfWeek.Monday:
                    shopping.Strategy = new LowDiscountStrategy();
                    break;
                default:
                    shopping.Strategy = new NoDiscountStrategy();
                    break;
            }
            Console.WriteLine($"Final Bill : {shopping.GetFinalBill()}");

        }
    }
}
