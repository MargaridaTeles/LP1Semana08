using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Unit[] units = new Unit[]
            {
                new SettlerUnit(),
                Military()
            };
            
            foreach(Unit u in units)
            {
                u.Move();
                Console.WriteLine(u.ToString());
            }
        }

        private static MilitaryUnit Military()
        {
            var m = new MilitaryUnit(2, 0, 7);

            m.Attack(new SettlerUnit());
            m.Attack(new SettlerUnit());

            return m;
        }
    }
}
