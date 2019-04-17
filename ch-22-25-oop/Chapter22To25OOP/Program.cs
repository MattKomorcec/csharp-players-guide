using System;
using System.Collections.Generic;

namespace Chapter22To25OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITank> tanks = new List<ITank>();
            HeavyTank heavyTank = new HeavyTank("Tiger I");
            SPG spgTank = new SPG("Hummel");

            tanks.Add(heavyTank);
            tanks.Add(spgTank);

            heavyTank.Shoot();
            spgTank.Aim();
            spgTank.Shoot();
            heavyTank.Move();

            Console.WriteLine($"We have: {tanks.Count} tanks!");

            Console.ReadKey();
        }
    }
}
