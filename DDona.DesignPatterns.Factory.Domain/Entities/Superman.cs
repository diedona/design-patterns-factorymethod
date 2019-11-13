using DDona.DesignPatterns.Factory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.Factory.Domain.Entities
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
