using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Witch : Character
    {
        public int Intelligence { get; private set; }
        
        public Witch(string name, int health, int damage, int intelligence) : base (name, health, damage)
        {
            Intelligence = intelligence;
        }

        public override void Describe()
        {
            Console.WriteLine($"{Name} [Witch] (Health: {Health}, Damage: {Damage}, Intelligence: {Intelligence})");
        }

        public override void Attack()
        {
            Console.WriteLine("Attack: Essence Drain!");
        }
    }
}