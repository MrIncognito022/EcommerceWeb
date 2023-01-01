using DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class CategoryRepository
    {
        public static Category[] AddCategory(Category[] categories, int index)
        {
            Console.Clear();
            Category category = new Category();
            Console.WriteLine("-----------Add Category----------\n");
            Console.WriteLine("Enter the Category Name");
            category.CategoryName = Console.ReadLine();
            
            categories[index] = category;
            Console.WriteLine("Product Added Successfully");
            return categories;

            //--------------Display Products------------


        }

        public static void DisplayAllCategory(Category[] categories, int Index)
        {
            Console.Clear();
            for (int i = 0; i < Index; i++)
            {
                Console.WriteLine($"Product at Index {i + 1} is {categories[i].CategoryName}");
            }
        }


        public static Category[] UpdateCategory(Category[] categories, int index)
        {
            Console.Clear();
            Console.WriteLine("Enter index of category that you want to Update;");
            int EditIndex = Convert.ToInt32(Console.ReadLine());
            if (EditIndex <= index)
            {

                //if (books[EditIndex -1].Title != null)
                //{

                //}
                Console.WriteLine("Enter category Name to update");
                categories[EditIndex - 1].CategoryName = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
            return categories;
        }


    }
}
