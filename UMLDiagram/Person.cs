using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram
{
    class Person
    {
        private Head head { get; set; }
        private Hand[] hands = new Hand[2];
        private Leg[] legs = new Leg[2];
        public void AddLimbs()
        {
            hands[0] = new Hand();
            hands[1] = new Hand();

            legs[0] = new Leg();
            legs[1] = new Leg();
        }


    }

    class Head
    {

    }

    class Hand
    {

    }

    class Leg
    { 
    
    }
}
