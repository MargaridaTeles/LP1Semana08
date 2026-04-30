using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Templar : Character
    {
        public int Strength { get; private set; }
        
        public int Intelligence { get; private set; }
        
        public Templar(string name, int health, int damage, int strength, int intelligence) : base (name, health, damage)
        {
            Strength = strength;
            Intelligence = intelligence;
        }

        public override void Describe()
        {
            Console.WriteLine($"{Name} [Templar] (Health: {Health}, Damage: {Damage}, Strength: {Strength}, Intelligence: {Intelligence})");
        }

        public override void Attack()
        {
            Console.WriteLine("Attack: Divine Blast!");
        }
    }
}