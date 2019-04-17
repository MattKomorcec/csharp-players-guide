using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter22To25OOP
{
    class HeavyTank : ITank
    {
        public string Name { get; private set; }

        public HeavyTank(string name)
        {
            Name = name;
        }
        public void Shoot()
        {
            Console.WriteLine($"{Name} shoots!");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moves!");
        }

        public void Aim()
        {
            Console.WriteLine($"{Name} aims!");
        }
    }
}
