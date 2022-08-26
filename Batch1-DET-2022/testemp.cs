using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class testemp
    {
        public static void Main()
        {
            empdetails e = new empdetails(22822, "ammu", new DateOnly(2021, 1, 1));
            Console.WriteLine($"years of experience{e.GetYearsofExp()}");
        }
    }
}
