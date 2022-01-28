using ConsoleApplication.Models;
using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication
{
    class Program
    {
        [DllImport("NativeLibrary.dll")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string GetName();

        [DllImport("NativeLibrary.dll")]
        public static extern void BuyShoe(Shoe shoe);

        [DllImport("NativeLibrary.dll")]
        public static extern Shoe CreateShoe(double shoeSize);

        static void Main(string[] args)
        {
            WishList wishList = new WishList("Life");
            wishList.Name = "Birthday";

            wishList.AddItem("Lamp");
            wishList.AddItem("Graphics Card");
            wishList.AddItem("Chipotle Burrito Bowl");
            wishList.RemoveItem("Lamp");

            Console.WriteLine($"{wishList.Name}: {wishList.Count} items");

            wishList.Print();

            Console.ReadLine();
        }
    }
}
