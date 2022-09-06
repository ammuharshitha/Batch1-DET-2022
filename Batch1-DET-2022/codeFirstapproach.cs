using Batch1_DET_2022.Models;
using Batch1_DET_2022.Models.data;
using Microsoft.EntityFrameworkCore;

namespace Batch1_DET_2022
{
    class codeFirstapproach

    {
        class BookTable
        {
            static void Main(string[] args)
            {
                //AddnewcustomerAndOrder();
                //GetAllCustomersWithOrder_EagerLoading();
                //GetAllCustomersWithOrder_ExplicitLoading();
                Disconnectedarchitecture();
                Console.ReadLine();
            }
            private static void AddnewcustomerAndOrder()
            {
                var ctx = new BookContext();

                Customer customer = new Customer();
                customer.ID = 1;
                customer.Name = "Harshitha";
                customer.Age = 22;


                Order ord = new Order();
                ord.Order_ID = 100;
                ord.Amount = 2000;
                ord.OrderDate = DateTime.Now;


                ord.cust = customer;
                try
                {
                    ctx.Orders.Add(ord);
                    ctx.SaveChanges();
                    Console.WriteLine("Customer and order is created");
                }
                catch (Exception ex)
                {

                }
            }


                private static void GetAllCustomersWithOrder_EagerLoading()
                {
                    //Eager loading means that the related data is loaded 
                    //from the database as part of the initial query.
                    var ctx = new BookContext();
                    try
                    {
                        var customers = ctx.Customers.Include("Orders");

                        //var customers = ctx.Customers.Include(o => o.Orders);                   

                        foreach (var customer in customers)
                        {
                            Console.WriteLine(customer.Name);
                            Console.WriteLine("----->");


                            foreach (var order in customer.Orders)
                            {
                                Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
                            }
                            Console.WriteLine("-----");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }


            private static void GetAllCustomersWithOrder_ExplicitLoading()
            {
                //Explicit loading means that the related data is
                //explicitly loaded from the database at a later time.
                //Needs MARS to be set to TRUE in connection string
                var ctx = new BookContext();
                try
                {
                    var customers = ctx.Customers;

                    foreach (var customer in customers)
                    {
                        Console.WriteLine(customer.Name);
                        Console.WriteLine("----->");

                        ctx.Entry(customer).Collection(o => o.Orders).Load();

                        foreach (var order in customer.Orders)
                        {
                            Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());

                        }
                        Console.WriteLine("-----");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            private static void Disconnectedarchitecture()
            {
                var ctx = new BookContext();

                var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

                ctx.Dispose();

                UpdateCustomerName(customer);

            }
            private static void UpdateCustomerName(Customer customer)
            {
                var ctx = new BookContext();
                customer.Name = "Mike";
                Console.WriteLine(ctx.Entry(customer).State.ToString());
                //ctx.Update<Customer>(customer);
                //OR
                ctx.Update(customer);
                //OR
                //ctx.Customers.Update(customer);
                //OR

                //  ctx.Attach(customer).State = EntityState.Modified;
                ctx.SaveChanges();
                Console.WriteLine("customer name is updated via disconnected mode");

            }



        }
    }
}


//            {
//                var ctx = new BookContext();
//                try
//                {
//                    Book book = ctx.Book.Where(b => b.BookID == 3).SingleOrDefault();
//                    ctx.Remove(book);
//                    ctx.SaveChanges();
//                    Console.WriteLine("Book deleted");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.InnerException.Message);
//                }
//            }

//            private static void AddBook()
//            {
//                var ctx = new BookContext();
//                Book book = new Book();
//                book.BookID = 11011;
//                book.BookName = "EF core";
//                book.author = "raj";
//                book.price = 100;

//                var ctxx = new BookContext();
//                Book boook = new Book();
//                book.BookID = 22022;
//                book.BookName = ".netcore";
//                book.author = "Wolf";
//                book.price = 200;

//                var cttx = new BookContext();
//                Book bok = new Book();
//                book.BookID = 33033;
//                book.BookName = "C#";
//                book.author = "j-hope";
//                book.price = 300;


//                try
//                {
//                    ctx.Book.Add(book);
//                    ctx.SaveChanges();
//                    Console.WriteLine("new book added");

//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.InnerException.Message);
//                }
//            }




//            private static void UpdateBook()
//            {

//                var ctx = new BookContext();
//                var Book = ctx.Book.Where(b => b.BookID == 1).SingleOrDefault();

//                try
//                {
//                    Book.BookName = "c#";
//                    Book.price = 600;
//                    ctx.Update(Book);
//                    ctx.SaveChanges();
//                    Console.WriteLine("Book updated");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.InnerException.Message);
//                }



//            }
//            private static void GetAllBook()
//            {
//                var ctx = new BookContext();
//                var Book = ctx.Book;

//                foreach (var e in Book)
//                {
//                    Console.WriteLine(e.BookName);
//                }




//            }
//        }
//    }
//}