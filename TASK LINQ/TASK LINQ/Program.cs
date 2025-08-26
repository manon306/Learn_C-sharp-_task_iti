using L2O___D09;

namespace TASK_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> all_products = new List<Product>()
            {
                new Product { ProductID = 1, ProductName = "Laptop", Category = "Electronics", UnitPrice = 15000, UnitsInStock = 5 },
                new Product { ProductID = 2, ProductName = "Mouse", Category = "Electronics", UnitPrice = 150, UnitsInStock = 20 },
                new Product { ProductID = 3, ProductName = "Keyboard", Category = "Electronics", UnitPrice = 300, UnitsInStock = 10 },
                new Product { ProductID = 4, ProductName = "Book", Category = "Stationery", UnitPrice = 50, UnitsInStock = 0 },
                new Product { ProductID = 5, ProductName = "Pen", Category = "Stationery", UnitPrice = 5, UnitsInStock = 0 }
            };
            List<Customer> all_customers = new List<Customer>()
            {
                new Customer("C001", "TechCorp") { Address = "123 Tech St", City = "Cairo", Country = "Egypt", Phone = "01012345678" },
                new Customer("C002", "StationeryWorld") { Address = "45 Paper Ave", City = "Alexandria", Country = "Egypt", Phone = "01234567890" },
                new Customer("C003", "GadgetHub") { Address = "78 Gadget Rd", City = "Giza", Country = "Egypt", Phone = "01123456789" },
                new Customer("C004", "BookStore") { Address = "9 Book Ln", City = "Cairo", Country = "Egypt", Phone = "01098765432" },
            };
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
            var PriceOver3=all_products2
                            .Where(p=>p.UnitPrice>3)
                            .ToList();
            Console.WriteLine("PRICE OVER #");
            foreach (var item in PriceOver3)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Returns digits whose name is shorter than their value.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
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
            var firstOutOfStock = all_products.FirstOrDefault(p=>p.UnitsInStock ==0 );
            Console.WriteLine("First out of stock product:");
            Console.WriteLine(firstOutOfStock);
            #endregion
            #region Return the first product whose Price > 1000, unless there is no match, in which case null is returned
            var firstPriceOver1000 = all_products.FirstOrDefault(p => p.UnitPrice > 1000);
            Console.WriteLine("First product with price over 1000:");
            #endregion
            #region Retrieve the second number greater than 5
            int[] A = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numbersGreaterThan5 = A.Where(n => n > 5).ToList();

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
            #region . Produce a Sequence containing the unique first letter from both product and customer names.
            
            #endregion


        }
    }
}
