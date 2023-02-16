using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Goblin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float hp = 936;
            float armor = 132;
            float armorStrength = 5;
            int n = 0;
           
            float physicalDamage = 174;
            float damageStrength = 5;
            for (int i = 0; i < 6; i++)
            {
                float damage = armor - physicalDamage;
               

                if (damage < 0)
                {
                    hp += damage;
                }
                n += 1;
                armor -= armorStrength;
                physicalDamage -= damageStrength;
                Console.WriteLine(hp);

                if (hp <= 0)
                {
                    Console.WriteLine("Kill");
                }

            }
            Console.ReadKey();
        }
    }
}
