using System;
using System.Collections;
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
            //var nameDesc = products
            //    .Select(x => new { x.ProductId, x.ProductName });

            //foreach (var item in nameDesc)
            //{
            //    Console.WriteLine(item.ToString());
            //}


            // Slide 43
            //Console.WriteLine("The overstock items! Cach 1");

            //var overstock1 = from p in products
            //                 where p.NumberInStock > 25
            //                 select p;
            //foreach (Products c in overstock1)
            //{
            //    Console.WriteLine(c.ToString());
            //}

            //Slide 44
            //Console.WriteLine("The overstock items! Cach 2");

            //var overstock2 = products.Where(x => x.NumberInStock > 25);
            //foreach (Products c in overstock2)
            //{
            //    Console.WriteLine(c.ToString());
            //}


            // Slide 45
            //ArrayList myStuff = new ArrayList();
            //myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });
            //var myInts = myStuff.OfType<int>();
            //Prints out 10, 400, and 8.
            //foreach (int i in myInts)
            //{
            //    Console.WriteLine("Int value: {0}", i);
            //}

            // Slide 46
            //ArrayList myCars1 = new ArrayList()
            //{
            //    new Car{ PetName = "Xe1", Color = "Bạc", Speed = 100, Make = "BMW"},
            //    new Car{ PetName = "Xe2", Color = "Đen", Speed = 55, Make = "Toyota"},
            //    new Car{ PetName = "Xe3", Color = "Xanh", Speed = 5, Make = "Honda"},
            //    new Car{ PetName = "X4", Color = "Trắng", Speed = 43, Make = "Ford"}
            //};
            //var myCarsEnum = myCars.OfType<Car>();
            //var fastCars = from c in myCarsEnum
            //               where c.Speed >= 55
            //               select c;
            //foreach (var car in fastCars)
            //{
            //    Console.WriteLine("{0} is going too fast! Speed ={1}", car.PetName,car.Speed.ToString());
            //}

            //Slide 48
            //PetOwner[] petList = GetPetList();
            //var query = from o in petList
            //            from p in o.Pets
            //            select p;
            //foreach (var p in query)
            //{
            //    Console.WriteLine(p);
            //}



            // Slide 49
            //PetOwner[] petOwnerList = GetPetList();
            //IEnumerable<string> query1 = petOwnerList.SelectMany(x => x.Pets);
            //Console.WriteLine("Using SelectMany():");
            //foreach (string pet in query1)
            //{
            //    Console.WriteLine(pet);
            //}

            // slide 50
            //PetOwner[] petOwnerList = GetPetList();
            //IEnumerable<List<String>> query2 = petOwnerList.Select(x=>x.Pets);
            //Console.WriteLine("\nUsing Selec():");
            //foreach (List<String> petList in query2)
            //{
            //    foreach (string pet in petList)
            //    {
            //        Console.WriteLine(pet);
            //    }
            //    Console.WriteLine();
            //}


            // SLide 51
            //var subset = from p in products
            //             orderby p.ProductName descending
            //             select p;
            //Console.WriteLine("Ordered by ProductName, Cach 1");
            //foreach(var item in subset)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            // slide 52
            //var subset2 = products.OrderByDescending(x => x.ProductName);
            //Console.WriteLine("Ordered by ProductName, Cach 2");
            //foreach(var i in subset2)
            //{
            //    Console.WriteLine(i.ToString());
            //}


            // slide 53
            //var subset = products
            //    .OrderBy(x => x.CategoryId)
            //    .ThenBy(x => x.ProductName);
            //Console.WriteLine("Ordered by CategoryId, ProductName:");
            //foreach (var p in subset)
            //{
            //    Console.WriteLine(p.ToString());
            //}


            // slide 54
            //Console.WriteLine("-----Group By cach 1 -------");
            //var query = from p in products
            //            group p by p.CategoryId;
            //foreach(var cate in query)
            //{
            //    Console.WriteLine("Category ID={0} bao gom :", cate.Key);
            //    foreach(var item in cate)
            //    {
            //        Console.Write("\t *** ");
            //        Console.WriteLine(item);
            //    }
            //}

            //slide 55
            //Console.WriteLine("\n-----Group By cach 2 -------");
            //var query2 = products.GroupBy(x => x.CategoryId);
            //foreach (var cate in query2)
            //{
            //    Console.WriteLine("Category ID={0} bao gom :", cate.Key);
            //    foreach (var item in cate)
            //    {
            //        Console.Write("\t *** ");
            //        Console.WriteLine(item);
            //    }
            //}


            // slide 56
            //var query = from p in products
            //            join c in categories
            //            on p.CategoryId equals c.CategoryId
            //            group p by new
            //            {
            //                c.CategoryId,
            //                c.CategoryName
            //            };
            //foreach(var cate in query)
            //{
            //    Console.WriteLine("Category={0}, bao gom: ",cate.Key);
            //    foreach(var item in cate)
            //    {
            //        Console.Write("\t *** ");
            //        Console.WriteLine(item);
            //    }
            //}


            //slide 57 
            //var query = from p in products
            //            group p by p.CategoryId into g
            //            select new
            //            {
            //                cate = g.Key,
            //                listPro = g
            //            };
            //foreach(var item in query)
            //{
            //    Console.WriteLine("Nhom CategoryID={0} bao gom: ",item.cate);
            //    foreach (var p in item.listPro)
            //    {
            //        Console.Write("\t *** ");
            //        Console.WriteLine(p);
            //    }
            //}

            // slide 58 
            //var query = products.GroupBy(x => x.CategoryId, x => x);
            //foreach(var item in query)
            //{                
            //    Console.WriteLine("Category={0}, bao gom: ", item.Key);
            //    foreach (Products pa in item)
            //    {
            //        Console.Write("\t *** ");
            //        Console.WriteLine(pa);
            //    }
            //}

            // slide 59
            //string[] strings =
            //{
            //    "A penny saved is a penny earned.",
            //    "The early bird catches the worm.",
            //};

            //var earlyBirdQuery =
            //    from sentence in strings
            //    let words = sentence.Split(' ')
            //    from word in words
            //    let w = word.ToLower()
            //    where w[0] == 'a' || w[0] == 'e' || w[0] == 'i'
            //        || w[0] == 'o' || w[0] == 'u'
            //    select w;

            //foreach(var v in earlyBirdQuery)
            //{
            //    Console.WriteLine("\"{0}\" starts with a vowel !!!! ", v);
            //}


            // Slide 60
            //Console.WriteLine(" --------- JOIN cach 1 ---------------");
            //var query = from c in categories
            //            join p in products
            //            on c.CategoryId equals p.CategoryId
            //            select new
            //            {
            //                p.ProductId,
            //                p.ProductName,
            //                c.CategoryName
            //            };
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}


            // slide 61
            //Console.WriteLine("\n --------- JOIN cach 2 ---------------");
            //var query2 = categories.Join(products, c => c.CategoryId, p => p.CategoryId, (c, p) => new
            //{
            //    p.ProductId,
            //    p.ProductName,
            //    c.CategoryName
            //});
            //foreach (var item in query2)
            //{
            //    Console.WriteLine(item);
            //}


            // slide 64
            //var allProducts = from p in products
            //                  select p;
            //Console.WriteLine(" --------- Khong reverse()---------------");
            //foreach (var p in allProducts)
            //{
            //    Console.WriteLine(p.ToString());
            //}
            //Console.WriteLine("\n --------- Co reverse()---------------");
            //foreach (var p in allProducts.Reverse())
            //{
            //    Console.WriteLine(p.ToString());
            //}

            //slide 65
            List<string> myCars1 =
                new List<String> { "Ford", "Honda", "Toyota" };
            List<string> yourCars1 =
                new List<String> { "BMW", "Toyota", "Hyundai" };

            //var carConcat = (from c in myCars1 select c)
            //    .Concat(from c2 in yourCars1 select c2);
            //Console.WriteLine(" --------- Khong xai  Distinct()---------------");
            //foreach (var s in carConcat )
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("\n --------- Co xai  Distinct()---------------");
            //foreach (var s in carConcat.Distinct())
            //{
            //    Console.WriteLine(s);
            //}

            // slide 66            
            //var carUnion = (from c1 in myCars1 select c1)
            //    .Union(from c2 in yourCars1 select c2);

            //Console.WriteLine(" ----------Union is everything:");
            //foreach (string s in carUnion)
            //{
            //    Console.WriteLine(s);
            //}

            // slide 67
            //var carIntersect = (from c1 in myCars1 select c1)
            //    .Intersect(from c2 in yourCars1 select c2);

            //Console.WriteLine(" ----------Intersection is everything:");
            //foreach (string s in carIntersect)
            //{
            //    Console.WriteLine(s);
            //}

            // slide 68
            var carDiff1 = (from c1 in myCars1 select c1)
                .Except(from c2 in yourCars1 select c2);
            var carDiff2 = (from c2 in yourCars1 select c2)
                .Except(from c1 in myCars1 select c1);

            Console.WriteLine("----------- Toi co ma ban ko co: ");
            foreach (string s in carDiff1)
            {
                Console.Write("\t   *** ");
                Console.WriteLine(s);
            }

            Console.WriteLine("\n----------- Ban co ma toi ko co: ");
            foreach (string s in carDiff2)
            {
                Console.Write("\t   *** ");
                Console.WriteLine(s);
            }
            
        }

        // Slide 47
        static PetOwner[] GetPetList()
        {
            PetOwner[] petOwners =
            { 
                new PetOwner { Name="Bảo", Pets = new List<string>{ "Chó", "Mèo"} },
                new PetOwner { Name="Thảo", Pets = new List<string>{ "Két", "Cá sấu"} },
                new PetOwner { Name="Tâm", Pets = new List<string>{ "Chuột", "Chó"} } 
            };
            return petOwners;
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
