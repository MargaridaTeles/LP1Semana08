using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Huntress : Character
    {
        public int Dexterity { get; private set; }
        
        public Huntress(string name, int health, int damage, int dexterity) : base (name, health, damage)
        {
            Dexterity = dexterity;
        }

        public override void Describe()
        {
            throw new NotImplementedException();
        }
    }
}