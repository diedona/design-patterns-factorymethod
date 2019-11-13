using DDona.DesignPatterns.FactoryMethod.Domain.Entities;
using DDona.DesignPatterns.FactoryMethod.Domain.Factories.Base;
using DDona.DesignPatterns.FactoryMethod.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.FactoryMethod.Domain.Factories
{
    public class SupermanFactory : HeroFactoryBase
    {
        public override ISuperHero Create()
        {
            return new Superman();
        }
    }
}
