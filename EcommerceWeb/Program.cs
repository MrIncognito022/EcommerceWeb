using DBModels;
using System;
using Infrastructure;

namespace EcommerceWeb
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool isProductLoopTerminate = false;
            Products[] products = new Products[100];
            int ProductIndex = 0;


            //------------------Main Menu---------------------

            do
            {
                Console.WriteLine("Choose the Option \n \t 1) Add a Product " +
                    "\n \t 2) Show All Products \n \t" +
                    " 3) Update Product \n \t 4) Delete Product ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        {
                            if (ProductIndex < products.Length)
                            {
                                ProductRepository.AddProducts(products, ProductIndex);
                                ProductIndex++;
                            }
                            else
                            {
                                Console.WriteLine("Limit is exceed");
                            }
                            break;
                        }
                    case "2":
                        {
                            ProductRepository.DisplayAllProducts(products, ProductIndex);
                            break;
                        }

                    case "3":
                        {
                            ProductRepository.UpdateProducts(products, ProductIndex);
                            break;
                        }
                    default:
                        {
                            isProductLoopTerminate = true;
                            break;
                        }
                }
            }while (!isProductLoopTerminate);
        }
    }
}
