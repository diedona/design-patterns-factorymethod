using DDona.DesignPatterns.FactoryMethod.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.FactoryMethod.Domain.Entities
{
    public class Superman : ISuperHero
    {
        public string HeroName { get { return "Superman"; } }

        public string GetDescription()
        {
            return "I'm Superman. This S means hope in my world.";
        }
    }
}
