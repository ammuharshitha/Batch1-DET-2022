using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Batch1_DET_2022.animal;
using static Batch1_DET_2022.cat;


namespace Batch1_DET_2022
{
    internal class animalpgm
    {
        
            public static void Main()
            {

                List<Animal> sound = new List<Animal>();
                
                sound.Add(new Cat());
                // list.Add(new Frog { Age = 4, Name = "Shino", Gender = "Male" });
                foreach (Animal a in sound)

                    Console.WriteLine(a.sound());



            }

        }
    }


