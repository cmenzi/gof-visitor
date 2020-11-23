using System;

namespace GoF.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Category { Name = "Catalog" };

            var category1 = new Category { Name = "Category 1" };
            var category11 = new Category { Name = "Category 11" };
            var category12 = new Category { Name = "Category 12" };
            var category2 = new Category { Name = "Category 2" };
            var category21 = new Category { Name = "Category 21" };
            var category22 = new Category { Name = "Category 22" };

            root.Add(category1);
            root.Add(category2);

            root.Add(new Product { Name = "Product RA0" });
            root.Add(new Product { Name = "Product RB0" });

            category1.Add(category11);
            category1.Add(category12);

            category2.Add(category21);
            category2.Add(category22);

            category11.Add(new Product { Name = "Product A11" });
            category11.Add(new Product { Name = "Product B11" });

            category12.Add(new Product { Name = "Product A12" });
            category12.Add(new Product { Name = "Product B12" });

            category21.Add(new Product { Name = "Product A21" });
            category21.Add(new Product { Name = "Product B21" });

            category22.Add(new Product { Name = "Product A22" });
            category22.Add(new Product { Name = "Product B22" });

            root.Accept(new TransformNameVisitor());

            Console.ReadKey();
        }
    }
}
