using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Furniture
    {
        public String material;
        public double price;

        public Furniture(string material, double price)
        {
            this.material = material;
            this.price = price;
        }

        public void DisplayFurnitureDetails()
        {
            Console.WriteLine("Material:" + material);
            Console.WriteLine("Price: "+ price);
        }

    }
    class Table : Furniture
    {
        public double height;
        public double surfaceArea;

        public Table(String material, double price, double height, double surfaceArea) : base(material, price)
        {
            this.height = height;
            this.surfaceArea = surfaceArea;
        }

        public void DisplayTableDetails()
        {
            DisplayFurnitureDetails();
            Console.WriteLine($"Height: {height} meters");
            Console.WriteLine($"Surface Area: {surfaceArea} square meters");
        }
    }
}
