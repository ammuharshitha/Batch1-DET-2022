using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Circle
{
    int r;


    public Circle(int r)
    {
        this.r = r;
    }


    public double GetArea()
    {
        return Math.PI * r * r;
    }
}
