using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S.O.L.I.D.LiskovSubstitution;

namespace S.O.L.I.D
{
    class Program
    {
        static void Main(string[] args)
        {
            //LiskovSubstitution
            Fruit fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
        }
    }
}
