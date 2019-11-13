using DDona.DesignPatterns.Factory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.Factory.Domain.Entities
{
    public class Wonderwoman : ISuperHero
    {
        public string HeroName { get { return "Wonderwoman"; } }

        public string GetDescription()
        {
            return "I'm princess Diana, but you might know me as WonderWoman.";
        }
    }
}
