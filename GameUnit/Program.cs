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
                new MilitaryUnit(3, 10, 7)
            };
            
            foreach(Unit u in units)
            {
                u.Move();
                Console.WriteLine(u.ToString());
            }
        }
    }
}
