using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class returnage
    {
        public static int age(DateTime dob)
        {
            int CurrentYear=DateTime.Now.Year;
            int C=DateTime.Now.Month;  
            return CurrentYear - dob.Year;

        }
       public static void Main()
        {
            DateTime Date=DateTime.Parse(Console.ReadLine());
            int res = (age(Date));
            Console.WriteLine($"your age is{res}");

        }
    }
}
