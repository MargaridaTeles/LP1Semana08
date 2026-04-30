using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Templar : Character
    {
        public int Strength { get; }
        
        public int Intelligence { get; }
        
        public Templar(string name, int health, int damage, int strength, int intelligence) : base (name, health, damage)
        {
            Strength = strength;
            Intelligence = intelligence;
        }

        public override void Describe()
        {
            throw new NotImplementedException();
        }
    }
}