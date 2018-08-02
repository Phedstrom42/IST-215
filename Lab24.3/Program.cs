using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24._3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CUSTOMER_ORDEREntities())
            {
                var query1 = from c in db.CUSTOMERs
                             join o in db.ORDERs
                             on c.CustomerID equals o.CustomerID
                             orderby c.CustomerID
                             select new
                             {
                                 o.CustomerID,
                                 CustomerName = c.CustomerName.Trim(),
                                 o.OrderNum,
                                 ProductName = o.ProductName.Trim(),
                             };
                Console.WriteLine($"CustomerID OrderNum {"Customer Name ",20} {"Product Name",-30}");
                query1.ToList().ForEach(x => Console.WriteLine(x));

                Console.WriteLine("\nUPDATE - Find Customer \"Jacobs, Nancy\" and changr it to Quimby, Marcus");
                var result = db.CUSTOMERs.SingleOrDefault(n => n.CustomerName.Equals("Jacobs, Nancy"));
                if(result != null)
                {
                    result.CustomerName = "Quimby, Marcus";
                    db.SaveChanges();
                }

                query1.ToList().ForEach(x => Console.WriteLine(x));

                /*
                 * ADD
                 */
                Console.WriteLine("\nAdd a new Customer name Nick Skoolicas");
                var customer = new CUSTOMER
                {
                    CustomerName = "Skoolicas, Nickalus",
                    EmailDomain = "NSkoolicas@somewhere.com",
                    PhoneAreaCode = "222",
                    City = "Concord",
                    State = "NH",
                    ZIP = "03301"
                };

                try
                {
                    db.CUSTOMERs.Add(customer);
                    db.SaveChanges();
                }
                catch (Exception e)
                {

                    Console.WriteLine($"{e.Message}\n{e.StackTrace}");
                }

                var query2 = from c in db.CUSTOMERs                           
                             orderby c.CustomerID
                             select new
                             {
                                 c.CustomerID,
                                 CustomerName = c.CustomerName.Trim()
                             };
                Console.WriteLine($"CustomerID OrderNum {"Customer Name ",20} {"Product Name",-30}");
                query2.ToList().ForEach(x => Console.WriteLine(x));

            }

        }
    }
}
