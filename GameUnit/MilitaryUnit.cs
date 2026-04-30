

namespace GameUnit
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }


        // Health = Health base + XP
        public override int Health
        {
            get => base.Health + XP;
            set => base.Health = value;
        }

        // Cost = AttackPower + XP
        public override float Cost => AttackPower + XP;

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }

        // Attack: aumenta XP e causa dano igual a AttackPower
        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }

        public override string ToString()
        {
            return base.ToString() + $" AP={AttackPower} XP={XP}";
        }


    }
}
