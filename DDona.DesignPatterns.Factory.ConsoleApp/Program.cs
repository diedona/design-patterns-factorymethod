using DDona.DesignPatterns.FactoryMethod.Domain.Enums;
using DDona.DesignPatterns.FactoryMethod.Domain.Factories;
using DDona.DesignPatterns.FactoryMethod.Domain.Interfaces;
using System;

namespace DDona.DesignPatterns.FactoryMethod.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // i dont need to know which specific super hero i'm calling
            // i only know i need someone for an "intelligence situation"
            ISuperHero superHero = HeroFactory.InitializeFactories().GetHero(ESituationType.Intelligence);

            Console.WriteLine(superHero.HeroName);
            Console.WriteLine(superHero.GetDescription());
        }
    }
}
