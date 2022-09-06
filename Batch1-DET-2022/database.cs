using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    class database
    {
        public static void Main()
        {
            //GetEmpDetailsByID();

            //DeleteEmployeeDetails();
            // EmpDetailsbyemplno();
            // DeleteEmployeeDetails();

            // Updateempdetails();
            updatenames();
            Console.ReadLine();
        }



        //private static void GetAllEmpDetails()
        //{
        //    var ctx = new TrainingContext();
        //    var emps = ctx.Emps;

        //    foreach(var emp in emps)
        //    {
        //        Console.WriteLine(emp.Ename + " " + emp.Sal);
        //    }

        //private static void DeleteEmployeeDetails()
        //{


        //    var ctx = new TrainingContext();
        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 7782;
        //        employee.Ename = "harshu";
        //        employee.Sal = 15000;
        //        employee.Deptno = 30;
        //        employee.Job = "Traineer";
        //        ctx.Update(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New employee Added");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }




        //with parameter.
        //public static void EmpDetailsbyemplno()
        //{
        //    var ctx = new TrainingContext();
        //    var employee = ctx.Emps.FromSqlRaw($"GetEmpsDetailsByemplno @p0", 7900).ToList();

        //    foreach (var e in employee)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }


        //without parameter
        //private static void EmployeeDetails()
        //{
        //    var ctx = new TrainingContext();
        //    var employees = ctx.Emps.FromSqlRaw($"GetAllEmpsDetails").ToList();



        //    foreach (var e in employees)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }
        //}


        //private static void DeleteEmployeeDetails()
        //{
        //    var ctx = new TrainingContext();
        //    try
        //    {
        //        var Value = 7900;
        //        int employee = ctx.Database.ExecuteSqlRaw("removeemployee @p0", Value);
        //        Console.WriteLine(employee);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }

        //private static void Updateempdetails()
        //{
        //    var ctx = new TrainingContext();
        //    try
        //    {
        //        var id = 7900;
        //        string newName = "Rashmi";
        //        int employee = ctx.Database.ExecuteSqlRaw("updatenames @p0,@p1", id, newName);
        //        Console.WriteLine(employee);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }




        private static void updatenames()
        {
            var ctx = new TrainingContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = 7566
                        },

                         new SqlParameter() {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data. SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data. ParameterDirection.Input,
                            Value = "ammu",
                        }

                       //    new SqlParameter() {
                       //     ParameterName = "@deptno",
                       //     SqlDbType =  System.Data. SqlDbType.Int,
                       //     Size = 100,
                       //     Direction = System.Data. ParameterDirection.Input,
                       //     Value = "20"},
                       };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("updatenames @empno, @ename",  param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                throw;
            }


            Console.WriteLine("update successful");

        }



    }

}


        


           








        
    
    
    



    
