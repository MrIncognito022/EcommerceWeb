using DBModels;
using System;

namespace Infrastructure
{
    public class ProductRepository
    {
        public static Products[] AddProducts(Products[] products, int index)
        {
            Console.Clear();
            Products product = new Products();
            Console.WriteLine("-----------Add Products----------\n");
            Console.WriteLine("Enter the product Name");
            product.ProductName = Console.ReadLine();
            products[index] = product;
            Console.WriteLine("Product Added Successfully");
            return products;


            //--------------Display Products------------

        }

        public static void DisplayAllProducts(Products[] products, int Index)
        {
            Console.Clear();
            for (int i = 0; i < Index; i++)
            {
                Console.WriteLine($"Product at Index {i +1} is {products[i].ProductName}");
            }
        }

        //----------------Update Book---------------------

        public static Products[] UpdateProducts(Products[] products, int index)
        {
            Console.Clear();
            Console.WriteLine("Enter index of Product that you want to Update;");
            int EditIndex = Convert.ToInt32(Console.ReadLine());
            if (EditIndex <= index)
            {

                //if (books[EditIndex -1].Title != null)
                //{

                //}
                Console.WriteLine("Enter Product Name to update");
                products[EditIndex - 1].ProductName = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
            return products;
        }

        public static void DeleteProduct(int index)
        {

        }


    }
}
