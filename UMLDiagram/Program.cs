using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Boat boat = new Boat();

            Console.WriteLine(car);
            Console.WriteLine(boat);
            Console.ReadLine();
        }
    }
}
