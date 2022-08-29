using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Batch1_DET_2022.student;

namespace Batch1_DET_2022
{
    internal class Sciencestudent
    {
        internal class ScienceStudent : Student
        {
            public int physics { get; set; }
            public int chemistry { get; set; }

            public int maths { get; set; }

            public override double GetAvgMarks()
            {
                return (physics + chemistry + maths) / 3;
            }
        }
    }

}
