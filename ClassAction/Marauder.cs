using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Marauder : Character
    {
        public int Strength { get; private set; }
        public Marauder(string name, int health, int damage, int strength) : base (name, health, damage)
        {
            Strength = strength;
        }

        public override void Describe()
        {
            throw new NotImplementedException();
        }
    }
}