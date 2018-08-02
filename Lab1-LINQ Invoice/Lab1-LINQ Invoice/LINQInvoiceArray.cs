using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_LINQ_Invoice
{
    class LINQInvoiceArray
    {
        static void Main(string[] args)
        {
            Invoice[] invoices =
             {
                new Invoice( 83, "Electric sander", 7, 57.98M),
                new Invoice( 24, "Power saw", 18, 99.99M),
                new Invoice( 7, "Sledge hammer", 11, 21.5M),
                new Invoice( 77, "Hammer", 76, 11.99M),
                new Invoice( 39, "Lawn mower", 3, 79.5M),
                new Invoice( 68, "Screwdriver", 106, 6.99M),
                new Invoice( 56, "Jig saw", 21, 11M),
                new Invoice( 3, "Wrench", 34, 7.5M)
            };

            // a) Use LINQ to sort invoices by description

            var sortedByDiscription =
                from item in invoices
                orderby item.PartDescription
                select item;

            // Display invoices sorted by discription

            Console.WriteLine("a) Sorted by description:\n");
            foreach (var item in sortedByDiscription)
                Console.WriteLine(item);

            // b) Use LINQ to sort invoices by price

            var sortedByPrice =
                from item in invoices
                orderby item.Price
                select item;

            // Display invoices sorted by price

            Console.WriteLine("\n\nb) Sorted by price:\n");
            foreach (var item in sortedByPrice)
                Console.WriteLine(item);

            // c) Use LINQ to select description and quantity, sort by quantity

            var desciptionAndQuantity =
                from item in invoices
                orderby item.Quantity
                select new { item.PartDescription, item.Quantity };

            // Display invoices description and quantity, sort by quantity

            Console.WriteLine("\n\nc) Description and quantity, sort by quantity:\n");
            foreach (var item in desciptionAndQuantity)
                Console.WriteLine(item);

            // d) Use LINQ to select description and calculate invoice total
            //    Sort by invoice total

            var descriptionAndTotal =
                from item in invoices
                let total = item.Price * item.Quantity
                orderby total
                select new { item.PartDescription, InvoiceTotal = total };

            // Display invoices description and invoice total, sorted by total

            Console.WriteLine("\n\nd) Description and invoice total, sort by invoice total:\n");
            foreach (var item in descriptionAndTotal)
                Console.WriteLine(item);

            // d) Use LINQ filter previous query results on range of totals
            var totalBetween200And500 =
                from item in descriptionAndTotal
                where item.InvoiceTotal > 200M && item.InvoiceTotal < 500M
                select item;

            // display filtered deescription and invoice totals
            Console.WriteLine("\n\ne) Invoice totals between $200.00 and $500.00:\n");
            foreach (var item in totalBetween200And500)
                Console.WriteLine(item);
        }
    }
}
