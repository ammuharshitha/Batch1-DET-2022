
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class program1
    {
        class MyClass
       // {
            //            enum Grade { Pass = 60, Distinction = 85 };
            //            /// <summary>
            //            /// method that returns Grade based on the mark
            //            /// </summary>
            //            /// <param name="mark">mark as the input</param>
            //            /// <returns></returns>
            //            public static string GetGrade(int mark) //IN parameter
            //            {
            //                if (mark >= (int)Grade.Distinction)
            //                    return "Distinction";
            //                else if (mark >= (int)Grade.Pass)
            //                    return "PASS";
            //                else
            //                    return "FAIL";
            //            }
            //            public static void Main()
            //            {
            //                try
            //                {
            //                    empdetails m = new Manager(4671, "Karthika", new DateOnly(2005, 5, 10), "techtrng", 10);  //default constructor
            //                                                                                                              // Console.WriteLine(m.Print());
            //                    empdetails m1 = new Manager(2345, "Jeeva", new DateOnly(2010, 1, 14), "PEMS", 450);
            //                    // Console.WriteLine(m1.Print());  //base class ref can point to derived object

            //                    empdetails e1 = new empdetails(1, "Jiyana", new DateOnly(2020, 1, 5));
            //                    //Console.WriteLine(e1.Print());

            //                    Console.WriteLine("enter empid b.w 1001 - 25000");
            //                    int id = Convert.ToInt32(Console.ReadLine());
            //                    if (id < 1001 || id > 25000)
            //                        throw new InvalidEmpld("Entered empid is not in the range...");

            //                    Console.WriteLine("enter emp name");
            //                    string name = Console.ReadLine();

            //                    Console.WriteLine("enter doj");
            //                    DateTime doj = DateTime.Parse(Console.ReadLine());

            //                    empdetails e2 = new(id, name, doj);


            //                    List<empdetails> list = new List<empdetails>();
            //                    list.Add(m);
            //                    list.Add(m1);
            //                    list.Add(e1);
            //                    foreach (empdetails x in list)
            //                        Console.WriteLine(x.Print());
            //                }
            //                catch (InvalidEmpld i)
            //                {
            //                    Console.WriteLine(i.Message);
            //                }
            //                catch (Exception i)
            //                { }




            //            }
            //        }
            //    }
            //}
            //            public static void Main()
            //            {
            //                Circ c = new Circ { Radius = 4 };
            //                Sphere s = new Sphere { Radius = 4 };

            //                Console.WriteLine(c.Area());
            //                Console.WriteLine(s.Area());
            //            }
            //        }
            //    }
            //}
           
            {
                enum grade { pass = 60, distinction = 85 };
                //method that returns grade based on the mark

                public static void getgrade(int mark) { } //in parameter
                public static void Main()
                {
                    #region "containment"
                    companymanager m = new companymanager { Name = "ammu", Surname = "s", PhoneNo = "9654869852" };
                    Company company = new Company { Name = "ssl", Address = "global city", Manager = m, PhoneNo = "9658748965", Website = "ssl.com" };

                    Console.WriteLine(company.Print());
                    #endregion
                    //manager m = new manager(6469,"chaitra",new datetime(2006,6,5),"tech",10); //default

                }
            }
        }
    }


   