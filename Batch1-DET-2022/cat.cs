using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Batch1_DET_2022.animal;

namespace Batch1_DET_2022
{
    internal class cat
    {

        public class Cat : Animal
        {
            public override string sound()
            {
                return "meow";
            }
        }
    }
}

