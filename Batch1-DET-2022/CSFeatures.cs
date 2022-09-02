using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($"hai {name}"); };
            Action<string,string> action1 = (string s1, string s2) => { Console.WriteLine($"hai {s1}," + $"have a {s2}"); };
            

            action.Invoke("ammu");
            action1.Invoke("ammu", "Good Day");

            Action<int, string, string> printEmp = (int id, string name, string email) =>
            {
                Console.WriteLine($"id={id},name={name},email={email}");
            };
            printEmp(22822, "ammu", "ammu.1434");

            HashSet<int> ids = new HashSet<int>();
            ids.Add(12345);
            ids.Add(12346);
            ids.Add(12367);
            ids.Add(12678);
            foreach(int id in ids)
                Console.WriteLine(id);


        }
    }
}

        