using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class empdetails
    {
        //data declared inside class are known as "fields"
        int id;
        string name;
        string dept;
        double sal;
        DateOnly doj;
        private DateTime doj1;

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public empdetails(int id, string name, DateOnly doj)
        {
            this.id = id; this.name = name; this.doj = doj;
        }
        public empdetails()
        {
            id = -1; name = "no name";
        }
        public empdetails(int id, string name)
        {
            this.id = id; this.name = name;
        }

        public empdetails(int id, string name, DateTime doj1) : this(id, name)
        {
            this.doj1 = doj1;
        }

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }
        public virtual string Print()   //only virtual method can be overridden
        {
            return $"Emp Id={id}, Name={name}, Experience={GetYearsofExp()} Years";
        }


    }
}
