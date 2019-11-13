using DDona.DesignPatterns.Factory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.Factory.Domain.Entities
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
