using System;

namespace ArchitectArithmetic
{
    class Program
    {
        /* 
        * Function that Launch of the program
        */
        public static void Main(string[] args) 
        {
             
            double fullprice = 0; // Variable Declaration

            
            double fullArea = calculateArea(out fullprice, 2500, 1500, 375, 750, 500); // Functions calls
            fullArea = calculateArea(out fullprice, 1000, 1000);

            
            Console.WriteLine($" La pièce mesure {fullArea} et le prix de construction est {fullprice}"); // Console call

        }

        
        /* 
        * Function that calculate area of a rectangle
        */
        static double Rectangle(double length, double width)
        {

            double area = length * width;
            Console.WriteLine("Rectangle = " + area);
            return area;

        }

         
        /* 
        * Function that calculate area of a Circle
        */
        static double Circle(double radius)
        {
         
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Circle = " + area);
            return area;

        }

        /**
         * Function that calculate area of a Triangle
         * 
         */
        static double Triangle(double bottom, double height)
        {

            double area = 0.5 * bottom * height;
            Console.WriteLine("triangle = " + area);
            return area;

        }


        /* 
         * Function that calculate the total area of a building
         * Take optionnal arguments to be used for different types of building
        */
        static double calculateArea(out double fullPrice, double length = 0, double width = 0, double radius = 0, double bottom = 0, double height = 0)
        {
            
            double flooringMaterialCost = 180; // Variable declaration

            
            double triangleArea = Triangle(bottom, height); // Call the functions that calculate the area based on the type of area
            double squareArea = Rectangle(length, width);
            double circleArea = Circle(radius);

            
            double fullArea = Math.Round(triangleArea + squareArea + circleArea, 2); // Calculate the total area of the building and round it to 2 decimals
            
            fullPrice = Math.Round(fullArea * flooringMaterialCost, 2); // Calculate the total price of the material for the building and round it to 2 decimals
            
            Console.WriteLine(fullArea + " " + fullPrice);
            
            return fullArea;

        }
    }
}
