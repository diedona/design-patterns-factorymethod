using DDona.DesignPatterns.Factory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.Factory.Domain.Factories.Base
{
    public abstract class HeroFactoryBase
    {
        public abstract ISuperHero Create();
    }
}
