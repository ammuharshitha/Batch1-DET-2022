using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class paramsPgm
    {
        public static int sum(params int[] arr)
        {
        int sum = 0;
            foreach (int i in arr)
                sum += i;
            return sum;

        }
        public static void Main()
        {
            int x;
            try
            {

                Console.WriteLine("enter the number b.w 1-10000");
                x = int.Parse(Console.ReadLine());
                if (x > 10000)
                   
                Console.WriteLine(sum(1, 2, 3,x));
                throw new InvalidDataException("number is not in range.........TRY Again");
            }

            
             catch (OverflowException ex)
                {
                    Console.WriteLine("please enter a number <=10000");
                }

            catch (FormatException ex)
            {
                Console.WriteLine("please enter a valid number");//user friendly messages
            }

            catch (Exception ex)
            {
               // Console.WriteLine("Sorry, error occured...contact admin");
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.Source);
                //Console.WriteLine(ex.StackTrace);
                
            }

            
            Console.WriteLine(sum(2, 3, 4, 5, 6, 7, 8, 9, 10));

            int[] a = { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10 };
            Console.WriteLine(sum(a));
        }
    }
}


