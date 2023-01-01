using DBModels;
using System;
using Infrastructure;

namespace EcommerceWeb
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isMenuTerminate= false;
            bool isManageCategory = false;
            bool isProductLoopTerminate = false;
            Products[] products = new Products[100];
            int ProductIndex = 0;


            //------------------Main Menu---------------------
            do
            {
                Console.WriteLine("Choose the option 1) Manage Category 2) Manage Products");
                var mainChoice = Console.ReadLine();





                if (mainChoice == "1")
                {
                    do
                    {
                        Console.WriteLine("Choose the Option \n \t 1) Add Category \n \t 2) Edit Category 3) Update Category");
                        var input1 = Console.ReadLine();
                        switch (input1)
                        {
                            case "1":
                                {
                                    break;
                                }
                            case "2":
                                {
                                    break;
                                }
                            case "3":
                                {
                                    break;
                                }
                            default:
                                {
                                    
                                    isManageCategory = true;
                                    break;
                                }
                        }// End ManageCategorySwitch
                    } while (!isManageCategory);





                }
                else if (mainChoice == "2")
                {

                    //------------------Product Menu------------------
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
                    } while (!isProductLoopTerminate);
                }//end Else if 

                else
                {
                    isMenuTerminate = true;
                }//End MainMenu
            }while (!isMenuTerminate);
        }
    }
}
