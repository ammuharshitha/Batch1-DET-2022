using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class PersonAge
    {
        static void Main()
        {
            Console.WriteLine("Enter the Age");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {

                if (age > 120)
                {
                    throw new Exception("Age is invalid");
                }
                else
                {
                    Console.WriteLine($"Age is {age}");
                }
            }
            catch (InvalidAgeException i)
            {
                Console.WriteLine(i.message);

            }
            catch (Exception e)
            {
            }

        }
    }
}