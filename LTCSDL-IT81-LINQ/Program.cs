﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LTCSDL_IT81_LINQ
{
    class Program
    {
        delegate int Transformer(int x);
        static int Square(int x) { return x * x; }
        static int Square2(int x) => x * x;

        static void Main(string[] args)
        {
            Console.WriteLine("LTCSDL - IT81 - LINQ \n");

            // Slide 8
            //var myInt = 0;
            //var myBool = true;
            //var myString = "Time, marches on...";
            //// Print out the underlying type.
            //Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            //Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            //Console.WriteLine("myString is a: {0}", myString.GetType().Name); 

            // Slide 10
            //Point firstPoint = new Point();
            //firstPoint.X = 10;
            //firstPoint.Y = 10;
            //Console.Write("First point : ");
            //firstPoint.DisplayStats();
            //Console.WriteLine();

            //// Or make a Point via a custom constructor.
            //Point anotherPoint = new Point(20, 20);
            //Console.Write("Another point : ");
            //anotherPoint.DisplayStats();
            //Console.WriteLine();

            //// Or make a Point using object init syntax.
            //Point finalPoint = new Point { X = 30, Y = 30 };
            //Console.Write("Final point : ");
            //finalPoint.DisplayStats();
            //Console.WriteLine();
            //Console.ReadLine();

            // Slide 11
            //List<Point> myListOfPoints = new List<Point>
            //{
            //    new Point { X = 2, Y = 2 },
            //    new Point { X = 3, Y = 3 },
            //    new Point { X = 4, Y = 1 },
            //};

            //foreach (var pt in myListOfPoints)
            //{
            //    Console.Write("Point : ");
            //    pt.DisplayStats();
            //    Console.WriteLine();
            //}

            // Slide 13
            //Transformer t = Square; // Create delegate instance
            //                        // hoặc
            //                        //Transformer t = new Transformer(Square); 

            //int result = t(3); // Invoke delegate
            //                   // hoặc
            //                   //int result = t.Invoke(3);
            //Console.Write("t(3)=Square(3)=");
            //Console.WriteLine(result); // 9

            // slide 15
            //Transformer t = Square2; // Create delegate instance            
            //int result = t(3); // Invoke delegate            
            //Console.WriteLine(result); // 9

            // slide 20
            //int myInt = 2021;
            //// Use new integer functionality.
            //Console.WriteLine("Value of myInt: {0}", myInt);
            //Console.WriteLine("Reversed digits of myInt: {0}",
            //myInt.ReverseDigits());
            //Console.ReadLine();


            // slide 23
            //var myCar = new
            //{
            //    Color = "Bright Pink",
            //    Make = "Saab",
            //    CurrentSpeed = 55
            //};
            //// Now show the color and make.
            //Console.WriteLine("My car is a {0} {1}.", myCar.Color, myCar.Make);
            //// Now call our helper method to build anonymous type via args.
            //BuildAnonType("BMW", "Black", 90);
            //Console.ReadLine();

            // slide 27
            //int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            //// Print only items less than 10.
            //IEnumerable<int> subset = from i in numbers
            //                          where i < 10
            //                          select i;
            //foreach (int i in subset)
            //    Console.WriteLine("Item: {0}", i);


            // Slide 29
            //string[] fruits = { "Chuoi", "Thanh Long", "Sau rieng", "Cam", "Dua hau" };

            //IEnumerable<string> subset = from g in fruits
            //                             where g.Contains(" ")
            //                             orderby g descending
            //                             select g;

            //foreach (string s in subset)
            //    Console.WriteLine("Item: {0}", s);

            // Slide 31
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //IEnumerable<int> query = nums.Where(n => n % 2 == 0);

            //foreach (var n in query)
            //{
            //    Console.WriteLine("{0}", n);
            //}

            // Slide 35 ~ 
            List<Car> myCars = new List<Car>()
            {
                new Car{ PetName = "Xe1", Color = "Bạc", Speed = 100, Make = "BMW"},
                new Car{ PetName = "Xe2", Color = "Đen", Speed = 55, Make = "Toyota"},
                new Car{ PetName = "Xe3", Color = "Xanh", Speed = 5, Make = "Honda"},
                new Car{ PetName = "Xe4", Color = "Trắng", Speed = 43, Make = "Ford"}
            };

            //Slide 38~
            Categories[] categories = new[]
            {
                new Categories {CategoryId = 1, CategoryName = "Nuoc ngot" },
                new Categories {CategoryId = 2, CategoryName = "Van phong pham" },
                new Categories {CategoryId = 3, CategoryName = "Thuc pham" }
            };

            Products[] products = new[]
            {
                new Products {ProductId = 11, ProductName = "Pepsi", NumberInStock = 10, CategoryId = 1 },
                new Products {ProductId = 12, ProductName = "Coca", NumberInStock = 20, CategoryId = 1 },
                new Products {ProductId = 21, ProductName = "But bi", NumberInStock = 100, CategoryId = 2 },
            };

            // Slide 39
            //var allProducts = from p in products
            //                  select p;

            //foreach (var prod in allProducts)
            //{
            //    Console.WriteLine(prod.ToString());
            //}

            // Slide 40
            //var allProducts = products.Select(x => x);

            //foreach (var prod in allProducts)
            //{
            //    Console.WriteLine(prod.ToString());
            //}

            // Slide 41
            //var nameDesc = from p in products
            //               select new
            //               {
            //                   p.ProductId,
            //                   p.ProductName
            //               };
            //foreach (var item in nameDesc)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            // Slide 42
            var nameDesc = products
                .Select(x => new { x.ProductId, x.ProductName });

            foreach (var item in nameDesc)
            {
                Console.WriteLine(item.ToString());
            }


        }

        static void BuildAnonType(string make, string color, int currSp)
        {
            // Build anon type using incoming args.
            var car = new
            {
                Make = make,
                Color = color,
                Speed = currSp
            };
            // Note you can now use this type to get the property data!
            Console.WriteLine("You have a {0} {1} going {2} MPH",
                        car.Color, car.Make, car.Speed);
            // Anon types have custom implementations of each virtual 
            // method of System.Object. For example:
            Console.WriteLine("ToString() == {0}", car.ToString());
        }
    }
}
