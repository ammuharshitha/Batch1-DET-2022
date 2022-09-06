using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class bokkkk
    {
        internal int price;

        public string Name { get; set; }
            public int Price { get; set; }
            public int Qty { get; set; }
            public Author author { get; set; }  //containment
        public int BookID { get; internal set; }
        public string BookName { get; internal set; }

        public override string ToString()
            {
                return $"Book[name={Name},Author={this.author.ToString()},price={Price},qty={Qty}";
            }
        }

        public class TestBook
        {
            public static void Main()
            {
                bokkkk b = new bokkkk
                {
                    Name = "Mastering C#",
                    author = new Author { Name = "Ammu", EMail = "ammu.1434", Gender = 'f' },
                    Price = 1500,
                    Qty = 75
                };

                Author alex = new Author { Name = "anusha", EMail = "anusha.132", Gender = 'f' };
                bokkkk dummyBook = new bokkkk { Name = "C#", author = alex, Price = 19, Qty = 99 };
            }
        }
    }

