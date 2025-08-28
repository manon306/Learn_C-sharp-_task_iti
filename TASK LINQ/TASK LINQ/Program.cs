using L2O___D09;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TASK_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> all_products = new List<Product>(){
                new Product{ ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 39 },
                new Product{ ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.0000M, UnitsInStock = 17 },
                new Product{ ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.0000M, UnitsInStock = 13 },
                new Product{ ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22.0000M, UnitsInStock = 53 },
                new Product{ ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments", UnitPrice = 21.3500M, UnitsInStock = 0 },
                new Product{ ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments", UnitPrice = 25.0000M, UnitsInStock = 120 },
                new Product{ ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce", UnitPrice = 30.0000M, UnitsInStock = 15 },
                new Product{ ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments", UnitPrice = 40.0000M, UnitsInStock = 6 },
                new Product{ ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry", UnitPrice = 97.0000M, UnitsInStock = 29 },
                new Product{ ProductID = 10, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.0000M, UnitsInStock = 31 },
                new Product{ ProductID = 11, ProductName = "Queso Cabrales", Category = "Dairy Products", UnitPrice = 21.0000M, UnitsInStock = 22 },
                new Product{ ProductID = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products", UnitPrice = 38.0000M, UnitsInStock = 86 }

            };
            List<Customer> all_customers = new List<Customer>()
    {
        new Customer
        {
            CustomerID = "C001",
            CompanyName = "Tech Solutions",
            Address = "123 Main St",
            City = "Cairo",
            Region = "Cairo Governorate",
            PostalCode = "11511",
            Country = "Egypt",
            Phone = "+20 123456789",
            Fax = "+20 987654321",
            Orders = new Order[]
            {
                new Order { OrderID = 1, OrderDate = new DateTime(2025,8,1), Total = all_products[0].UnitPrice * 2 },
                new Order { OrderID = 2, OrderDate = new DateTime(2025,8,3), Total = all_products[1].UnitPrice * 1 }
            }
        },
        new Customer
        {
            CustomerID = "C002",
            CompanyName = "Global Traders",
            Address = "45 Nile St",
            City = "Alexandria",
            Region = "Alexandria Governorate",
            PostalCode = "21544",
            Country = "Egypt",
            Phone = "+20 234567890",
            Fax = "+20 876543210",
            Orders = new Order[]
            {
                new Order { OrderID = 3, OrderDate = new DateTime(2025,8,2), Total = all_products[2].UnitPrice * 3 },
                new Order { OrderID = 4, OrderDate = new DateTime(2025,8,4), Total = all_products[0].UnitPrice * 1 }
            }
        },
        new Customer
        {
            CustomerID = "C003",
            CompanyName = "Future Tech",
            Address = "78 Tahrir St",
            City = "Giza",
            Region = "Giza Governorate",
            PostalCode = "12522",
            Country = "Egypt",
            Phone = "+20 345678901",
            Fax = "+20 765432109",
            Orders = new Order[]
            {
                new Order { OrderID = 5, OrderDate = new DateTime(2025,8,5), Total = all_products[1].UnitPrice * 5 }
            }
        },
        new Customer
        {
            CustomerID = "C004",
            CompanyName = "Smart Solutions",
            Address = "12 Salah Salem",
            City = "Cairo",
            Region = "Cairo Governorate",
            PostalCode = "11512",
            Country = "Egypt",
            Phone = "+20 456789012",
            Fax = "+20 654321098",
            Orders = new Order[]
            {
                new Order { OrderID = 6, OrderDate = new DateTime(2025,8,6), Total = all_products[3].UnitPrice * 2 }
            }
        },
        new Customer
        {
            CustomerID = "C005",
            CompanyName = "Eco Products",
            Address = "56 Maadi St",
            City = "Cairo",
            Region = "Cairo Governorate",
            PostalCode = "11519",
            Country = "Egypt",
            Phone = "+20 567890123",
            Fax = "+20 543210987",
            Orders = new Order[]
            {
                new Order { OrderID = 7, OrderDate = new DateTime(2025,8,7), Total = all_products[4].UnitPrice * 10 }
            }
        }
    };
            string[] words = File.ReadAllLines("dictionary_english.txt");
            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] Arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            #region Find all products that are out of stock
            var outOfStock = all_products
                    .Where(p => p.UnitsInStock == 0)
                    .ToList();

            Console.WriteLine("Out of Stock Products:");
            foreach (var item in outOfStock)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region . Find all products that are in stock and cost more than 3.00 per unit
            List<Product> all_products2 = new List<Product>()
            {
                new Product { ProductID = 1, ProductName = "Laptop", Category = "Electronics", UnitPrice = 15000, UnitsInStock = 5 },
                new Product { ProductID = 2, ProductName = "Mouse", Category = "Electronics", UnitPrice = 150, UnitsInStock = 20 },
                new Product { ProductID = 3, ProductName = "Keyboard", Category = "Electronics", UnitPrice = 300, UnitsInStock = 10 },
                new Product { ProductID = 4, ProductName = "Book", Category = "Stationery", UnitPrice = 2, UnitsInStock = 0 },
                new Product { ProductID = 5, ProductName = "Pen", Category = "Stationery", UnitPrice = 3, UnitsInStock = 0 }
            };
            var PriceOver3 = all_products2
                            .Where(p => p.UnitPrice > 3)
                            .ToList();
            Console.WriteLine("PRICE OVER #");
            foreach (var item in PriceOver3)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Returns digits whose name is shorter than their value.
            List<string> arr2 = new List<string>();
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].Length < i)
                    arr2.Add(Arr[i]);
            }
            Console.WriteLine("DIGITS");
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Get first Product out of Stock
            var firstOutOfStock = all_products.FirstOrDefault(p => p.UnitsInStock == 0);
            Console.WriteLine("First out of stock product:");
            Console.WriteLine(firstOutOfStock);
            #endregion
            #region Return the first product whose Price > 1000, unless there is no match, in which case null is returned
            var firstPriceOver1000 = all_products.FirstOrDefault(p => p.UnitPrice > 1000);
            Console.WriteLine("First product with price over 1000:");
            #endregion
            #region Retrieve the second number greater than 5
            var numbersGreaterThan5 = Arr2.Where(n => n > 5).ToList();

            var secondNumber = numbersGreaterThan5.ElementAtOrDefault(1); // 1 لأن الفهرس يبدأ من 0

            Console.WriteLine($"Second number greater than 5: {secondNumber}");
            #endregion
            #region Find the unique Category names from Product List
            var Unique = all_products.Select(a => a.Category).Distinct().ToList();
            Console.WriteLine("Unique Categories:");
            foreach (var category in Unique)
            {
                Console.WriteLine(category);
            }
            #endregion
            #region Produce a Sequence containing the unique first letter from both product and customer names.
            var productFirstLetters = all_products
                                        .Select(p => p.ProductName[0]);
            var customerFirstLetters = all_customers
                                        .Select(c => c.CompanyName[0]);
            var uniqueFirstLetters = productFirstLetters.Concat(customerFirstLetters)
                                                                  .Distinct()
                                                                  .ToList();
            Console.WriteLine("Unique first letters from product and customer names:");
            foreach (var letter in uniqueFirstLetters)
            {
                Console.WriteLine(letter);
            }
            #endregion
            #region Create one sequence that contains the common first letter from both product and customer names.
            var commonFirstLetters = productFirstLetters.Intersect(customerFirstLetters).ToList();
            Console.WriteLine("Common first letters from product and customer names:");
            foreach (var letter in commonFirstLetters)
            {
                Console.WriteLine(letter);
            }
            #endregion
            #region Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            var productNotInCustomer = productFirstLetters.Except(customerFirstLetters).ToList();
            Console.WriteLine("First letters of product names not in customer names:");
            foreach (var letter in productNotInCustomer)
            {
                Console.WriteLine(letter);
            }
            #endregion
            #region Last 3 characters from product and customer names (including duplicates)
            var lastThreeInProductName = all_products
                .Where(p => p.ProductName.Length >= 3)
                .Select(p => p.ProductName.Substring(p.ProductName.Length - 3));

            var lastThreeInCompanyName = all_customers
                .Where(c => c.CompanyName.Length >= 3)
                .Select(c => c.CompanyName.Substring(c.CompanyName.Length - 3));

            var allLastThree = lastThreeInProductName
                .Concat(lastThreeInCompanyName)
                .ToList();

            Console.WriteLine("Last three characters in product and customer names:");
            Console.WriteLine(string.Join(", ", allLastThree));
            #endregion
            #region Uses Count to get the number of odd numbers in the array
            int oddNumbersCount = Arr2.Count(n => n % 2 != 0);
            Console.WriteLine($"Number of odd numbers in the array: {oddNumbersCount}");
            #endregion
            #region Return a list of customers and how many orders each has.
            var customerOrderCounts = all_customers
                .Select(c => new
                {
                    c.CompanyName,
                    OrderCount = c.Orders.Length
                })
                .ToList();
            Console.WriteLine("Customer Order Counts:");
            foreach (var customer in customerOrderCounts)
            {
                Console.WriteLine($"{customer.CompanyName}: {customer.OrderCount} orders");
            }
            #endregion
            #region Return a list of categories and how many products each has
            var CategoryProduct = all_products
                .GroupBy(p => p.Category)
                .Select(p => new
                {
                    Category = p.Key,
                    ProductCount = p.Count()
                });
            Console.WriteLine("Category Product Counts:");
            foreach (var category in CategoryProduct)
            {
                Console.WriteLine($"{category.Category}: {category.ProductCount} products");
            }
            #endregion
            #region Get the total of the numbers in an array
            var sum = Arr2.Sum();
            Console.WriteLine($"Sum of all numbers in the array: {sum}");
            #endregion
            #region Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            int totalCharacters = words.Sum(a => a.Length);
            Console.WriteLine($"Total number of characters in all words: {totalCharacters}");
            #endregion
            #region Get the total units in stock for each product category
            var totalUnitsInStockByCategory = all_products.
                                                    GroupBy(p => p.Category)
                                                    .Select(g => new
                                                    {
                                                        Category = g.Key,
                                                        TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
                                                    });
            foreach (var category in totalUnitsInStockByCategory)
            {
                Console.WriteLine($"{category.Category}: {category.TotalUnitsInStock} units in stock");
            }
            #endregion
            #region Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            int ShortLength = words.Min(a => a.Length);
            Console.WriteLine($"Length of the shortest word: {ShortLength}");
            #endregion
            #region Get the cheapest price among each category's products
            var CheapestByCategory = all_products
                             .GroupBy(p => p.Category)
                             .Select(g => new
                             {
                                 category = g.Key,
                                 cheap = g.Min(p => p.UnitPrice)
                             });
            Console.WriteLine("Cheapest price by category:");
            foreach (var category in CheapestByCategory)
            {
                Console.WriteLine($"{category.category}: {category.cheap} unit price");
            }
            #endregion
            #region . Get the products with the cheapest price in each category (Use Let)
            var CheapestByCategory2 = from p in all_products
                                      group p by p.Category into g
                                      let minPrice = g.Min(p => p.UnitPrice)
                                      select new {
                                          category = g.Key,
                                          cheap = minPrice
                                      };
            Console.WriteLine("Cheapest price by category:");
            foreach (var category in CheapestByCategory2)
            {
                Console.WriteLine($"{category.category}: {category.cheap} unit price");
            }
            #endregion
            #region Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            int LongLenght = words.Max(a => a.Length);
            Console.WriteLine($"Length of the longest word: {LongLenght}");
            #endregion
            #region Get the most expensive price among each category's products.
            var MostExInStockByEachCategory = all_products
                            .GroupBy(p => p.Category)
                            .Select(g => new
                            {
                                category = g.Key,
                                MostExpensive = g.Max(p => p.UnitPrice)
                            });
            Console.WriteLine("Most expensive price by category:");
            foreach (var category in MostExInStockByEachCategory)
            {
                Console.WriteLine($"{category.category}: {category.MostExpensive} unit price");
            }
            #endregion
            #region Get the products with the most expensive price in each category
            var PWithMostExInStockByEachCategory = all_products
                            .GroupBy(p => p.Category)
                            .Select(g =>
                            {
                                var maxPrice = g.Max(p => p.UnitPrice);
                                return new
                                {
                                    category = g.Key,
                                    MostExpensiveP = g.FirstOrDefault(a => a.UnitPrice == maxPrice)
                                };
                            });
            Console.WriteLine("Products with the most expensive price by category:");
            foreach (var category in PWithMostExInStockByEachCategory)
            {
                Console.WriteLine($"{category.category}: {category.MostExpensiveP} unit price");
            }
            #endregion
            #region Get the average length of the words in dictionary_english.txt (Read  dictionary_english.txt into Array of String First).
            var AvarageLength = words.Average(a => a.Length);
            Console.WriteLine($"Avarage length in Words is : {AvarageLength}");
            #endregion
            #region Get the average price of each category's products
            var AvarageByCategory = all_products
                .GroupBy(a => a.Category)
                .Select(g => new
                {
                    category = g.Key,
                    AVg = g.Average(a => a.UnitPrice)
                });
            Console.WriteLine("Average price by category:");
            foreach (var category in AvarageByCategory)
            {
                Console.WriteLine($"{category.category}: {category.AVg} unit price");
            }
            #endregion
            #region Sort a list of products by name
            var OrderByName = all_products
                .OrderBy(a => a.ProductName)
                .ToList();
            Console.WriteLine("Products sorted by name:");
            foreach (var product in OrderByName)
            {
                Console.WriteLine(product.ProductName);
            }
            #endregion
            #region Uses a custom comparer to do a case-insensitive sort of the words in an array.
            var SortArr = Arr3
                .OrderBy(a => a, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(string.Join(", ", SortArr));
            #endregion
            #region  Sort a list of products by units in stock from highest to lowest.
            var SortProduct = all_products
                .OrderByDescending(a => a.UnitPrice)
                .ToList();
            Console.WriteLine("Products sorted by units in stock (high to low):");
            foreach (var product in SortProduct)
            {
                Console.WriteLine($"{product.ProductName}: {product.UnitsInStock} units");
            }
            #endregion
            #region Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            var SortByDigit = all_products
                .OrderBy(a => a.ProductName.Length)
                .ThenBy(a => a.ProductName);
            Console.WriteLine("Products sorted by length and then alphabetically:");
            foreach (var product in SortByDigit)
            {
                Console.WriteLine(product.ProductName);
            }
            #endregion
            #region  Sort first by word length and then by a case-insensitive sort of the words in an array.
            var SortArrByLengthThenCase = Arr3
                .OrderBy(a => a.Length)
                .ThenBy(a => a, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(string.Join(", ", SortArrByLengthThenCase));
            #endregion
            #region Sort a list of products, first by category, and then by unit price, from highest to lowest.
            var SortByCategoryThenByPrice = all_products
                .OrderBy(p => p.Category)
                .ThenByDescending(p => p.UnitPrice);
            Console.WriteLine("Products sorted by category and then by price (high to low):");
            foreach (var product in SortByCategoryThenByPrice)
            {
                Console.WriteLine($"{product.Category}: {product.ProductName} - {product.UnitPrice} unit price");
            }
            #endregion
            #region  Sort first by word length and then by a case-insensitive descending sort of the words in an array
            var SortArrByLengthThenByCase = Arr3
                .OrderBy(a => a.Length)
                .ThenByDescending(a => a, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(string.Join(", ", SortArrByLengthThenByCase));
            #endregion
            #region Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array
            var ListOfArrSecondEleIsI = Arr
                .Where(a => a.Length > 1 && a[1] == 'i')
                .Reverse()
                .ToList();
            Console.WriteLine("Digits with second letter 'i' reversed:");
            foreach (var word in ListOfArrSecondEleIsI)
            {
                Console.WriteLine(word);
            }
            #endregion
            #region Get the first 3 orders from customers in Washington
            var Get3Orders = all_customers
                    .Where(c => c.City == "Washington")
                    .SelectMany(c => c.Orders, (customer, order) => new
                    {
                        CustomerID = customer.CustomerID,
                        OrderID = order.OrderID,
                        Total = order.Total
                    })
                    .Take(3)
                    .ToList();

            Console.WriteLine("First 3 orders from customers in Washington:");
            foreach (var order in Get3Orders)
            {
                Console.WriteLine($"OrderID: {order.OrderID}, CustomerID: {order.CustomerID}, Total: {order.Total}");
            }
            #endregion
            #region  Get all but the first 2 orders from customers in Washington.
            var GetAllExcF2InWashington = all_customers
                .Where(a => a.City == "Washington")
                .SelectMany(a => a.Orders)
                .Skip(2);
            Console.WriteLine("All but the first 2 orders from customers in Washington:");
            foreach (var order in GetAllExcF2InWashington)
            {
                Console.WriteLine($"OrderID: {order.OrderID}, Total: {order.Total}");
            }
            #endregion
            #region Return elements starting from the beginning of the array until a number is hit that is less than its position in the array
            var GetWhileEleMinThanIndex = Arr2
                .TakeWhile((value, Index) => value >= Index)
                .ToList();
            Console.WriteLine("Elements until a number is less than its index:");
            foreach (var item in GetWhileEleMinThanIndex)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region  Get the elements of the array starting from the first element divisible by 3.
            var GetAllAfterDivideby3 = Arr2
                .SkipWhile((Value) => Value % 3 != 0)
                .ToList();
            Console.WriteLine("Elements starting from the first divisible by 3:");
            foreach (var item in GetAllAfterDivideby3)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Get the elements of the array starting from the first element less than its position
            var GetAllAfterLessThanIndex = Arr2
                .SkipWhile((Value, Index) => Value >= Index)
                .ToList();
            Console.WriteLine("Elements starting from the first element less than its index:");
            foreach (var item in GetAllAfterLessThanIndex)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Return a sequence of just the names of a list of products.
            var SelectNamesOfProducts = all_products
                .Select(a => a.ProductName)
                .ToList();
            Console.WriteLine("Names of all products:");
            foreach (var name in SelectNamesOfProducts)
            {
                Console.WriteLine(name);
            }
            #endregion
            #region Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            var CaseOfWords = Arr3
                .Select(a => new
                {
                    Upper = a.ToUpper(),
                    Lower = a.ToLower()
                }).ToList();

            foreach (var item in CaseOfWords)
            {
                Console.WriteLine($"Upper: {item.Upper}, Lower: {item.Lower}");
            }
            #endregion
            #region Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type
            var SelectSeqOfProduct = all_products
                .Select(a => new
                {
                    ProductName = a.ProductName,
                    Price = a.UnitPrice,
                }).ToList();
            Console.WriteLine("Products with renamed Price property:");
            foreach (var product in SelectSeqOfProduct)
            {
                Console.WriteLine($"Product: {product.ProductName}, Price: {product.Price}");
            }
            #endregion
            #region Determine if the value of ints in an array match their position in the array
            var DetermineValueWithIndex = Arr2
                .Select((Value, Index) => new
                {
                    Value = Value,
                    Match = Value == Index
                }).ToList();
            Console.WriteLine("Number: In-place?");
            foreach (var item in DetermineValueWithIndex)
            {
                Console.WriteLine($"{item.Value}: {item.Match}");
            }
            #endregion
            #region  Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var MatchNumbers = numbersA.SelectMany(
                a => numbersB,
                (a, b) => new { A=a, B =b }
                ).Where(x =>x.A < x.B);
            foreach (var pair in MatchNumbers)
            {
                Console.WriteLine($"A: {pair.A}, B: {pair.B}");
            }
            #endregion
            #region Select all orders where the order total is less than 500.00.
            var SelectOrdersByPrice = all_customers
                .SelectMany(a=>a.Orders)
                .Where(a=>a.Total <500)
                .ToList();
            Console.WriteLine("Orders with Total < 500:");
            foreach (var order in SelectOrdersByPrice)
            {
                Console.WriteLine($"OrderID: {order.OrderID}, Date: {order.OrderDate.ToShortDateString()}, Total: {order.Total}");
            }

            #endregion
            #region Select all orders where the order was made in 1998 or later.
            var SelectByDateTime = all_customers
                .SelectMany(A => A.Orders)
                .Where(a => a.OrderDate.Year <= 1998)
                .ToList()
                ;
            foreach (var order in SelectByDateTime)
            {
                Console.WriteLine($"OrderID: {order.OrderID}, Date: {order.OrderDate}, Total: {order.Total}");
            }
            #endregion
            #region Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            var Word = words.Where(a => a.Contains("ei")).ToList();
            if (Word.Any())
            {
                Console.WriteLine("Words containing 'ei':");
                foreach (var w in Word)
                {
                    Console.WriteLine(w);
                }
            }
            else
            {
                Console.WriteLine("No words contain 'ei'.");
            }

            #endregion
            #region Return a grouped a list of products only for categories that have at least one product that is out of stock.
            var groupedProducts = all_products
                .GroupBy(p => p.Category)
                .Where(g => g.Any(p => p.UnitsInStock == 0))
                .ToList();
            foreach (var group in groupedProducts)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var product in group)
                {
                    Console.WriteLine($"  {product.ProductName} - Stock: {product.UnitsInStock}");
                }
            }
            #endregion
            #region Return a grouped a list of products only for categories that have all of their products in stock.
            var ListProduct = all_products
                .GroupBy(a => a.Category)
                .Where(a => a.All(p => p.UnitsInStock > 0))
                .ToList();
            foreach (var categoryGroup in ListProduct)
            {
                Console.WriteLine($"Category: {categoryGroup.Key}");
                foreach (var product in categoryGroup)
                {
                    Console.WriteLine($"   Product: {product.ProductName}, Stock: {product.UnitsInStock}");
                }
            }
            #endregion
            #region Use group by to partition a list of numbers by their remainder when divided by 5
            var GroubByDivied5 = Arr2.GroupBy(a => a % 5);
            foreach (var group in GroubByDivied5)
            {
                Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");

                foreach (var num in group)
                {
                    Console.WriteLine(num);
                }

                Console.WriteLine();
            }
            #endregion
            #region Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input
            var GroubByFirstLetter = words.GroupBy(a => a[0]).ToList();
            foreach (var group in GroubByFirstLetter)
            {
                Console.WriteLine($"Letter: {group.Key}");
                foreach (var word in group)
                {
                    Console.WriteLine($"   {word}");
                }
            }

            #endregion
            #region Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            string[] Arr4 = { "from ", " salt", " earn ", " last ", " near ", " form " };

            var result = Arr4
                .Select(word => word.Trim())                               
                .GroupBy(word => string.Concat(word.OrderBy(c => c)))      
                .ToList();

            foreach (var group in result)
            {
                Console.WriteLine("Group:");
                foreach (var word in group)
                {
                    Console.WriteLine($"   {word}");
                }
            }
            #endregion


        }
    }
}
