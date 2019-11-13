using DDona.DesignPatterns.FactoryMethod.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.FactoryMethod.Domain.Entities
{
    public class Batman : ISuperHero
    {
        public string HeroName { get { return "Batman"; } }

        public string GetDescription()
        {
            return "I'm Batman.";
        }
    }
}
