using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram
{
    abstract class Machine
    {
        public Engine AddEngine()
        {
            return new Engine();
        }
      
    }

    class Engine
    {
        private int maxPistons = 8;
        private int minPistons = 4;

        public int Pistons;
        public Piston[] AddPistons(int amount)
        {
            if (amount > maxPistons && amount < minPistons)
            {
                amount = minPistons;
            }
            Pistons = amount;

            Piston[] pistons = new Piston[amount];
            for (int i = 0; i < pistons.Length; i++)
            {
                pistons[i] = new Piston();
            }
            return pistons;

        }

        public Crankshaft AddCrankshaft()
        {
            return new Crankshaft();
        }

        public Engine()
        {
            AddPistons(4);
            AddCrankshaft();
        }
    }

    class Crankshaft
    {

    }

    class Piston
    {

    }

    class Car : Machine
    {
        private int amountWheels = 4;
        private Wheel[] AddWheels()
        {
            Wheel[] wheels = new Wheel[amountWheels];
            for (int i = 0; i < wheels.Length; i++)
            {
                wheels[i] = new Wheel();
            }

            return wheels;
        }
        public Car()
        {
            AddWheels();
            AddEngine();
        }

        public override string ToString()
        {
            return $"Deze auto heeft {amountWheels} wielen.";
        }
    }

    class Wheel
    {

    }


    class Boat : Machine
    {
        private int maxPropellers = 4;
        private int minPropellers = 1;

        public int Propellers;
        public Propeller[] AddPropellers(int amount)
        {
            if (amount > maxPropellers && amount < minPropellers)
            {
                amount = minPropellers;
            }
            Propellers = amount;

            Propeller[] propellers = new Propeller[amount];
            for (int i = 0; i < propellers.Length; i++)
            {
                propellers[i] = new Propeller();
            }
            return propellers;
        }

        public Boat()
        {
            AddEngine();
            AddPropellers(2);
        }

        public override string ToString()
        {
            return $"Deze boot heeft {Propellers} propellers.";
        }
    }

    class Propeller
    {

    }
}
