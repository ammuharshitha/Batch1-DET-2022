﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Website { get; set; }
        public companymanager Manager { get; set; } //containment
        public string Print()
        {
            return $"Name={Name}, Address={Address}, PhoneNo={PhoneNo}, Website={Website}, Manager={Manager.Print()}";
        }
    }
}

