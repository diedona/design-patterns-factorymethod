using DDona.DesignPatterns.FactoryMethod.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.FactoryMethod.Domain.Factories.Base
{
    public abstract class HeroFactoryBase
    {
        public abstract ISuperHero Create();
    }
}
