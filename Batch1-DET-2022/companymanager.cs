using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch1_DET_2022
{
    internal class companymanager
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNo { get; set; }

        public string Print()
        {
            return $"Name={Name}, Surname={Surname}, PhonNo={PhoneNo}";

        }
    }

}

