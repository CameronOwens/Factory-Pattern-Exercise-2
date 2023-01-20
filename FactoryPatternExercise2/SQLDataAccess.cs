using System;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product (){ Name="Oculus", Price = 300},
            new Product (){ Name="Piano", Price = 1200},
            new Product (){ Name="KitchenAid", Price = 700},
            new Product (){ Name="Skateboard", Price = 100}

        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading date from the SQL Data Access.");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL Data Access.");
        }
    }
}

