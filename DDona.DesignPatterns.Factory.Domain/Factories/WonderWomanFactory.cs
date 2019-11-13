using DDona.DesignPatterns.Factory.Domain.Entities;
using DDona.DesignPatterns.Factory.Domain.Factories.Base;
using DDona.DesignPatterns.Factory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.Factory.Domain.Factories
{
    public class WonderWomanFactory : HeroFactoryBase
    {
        public override ISuperHero Create()
        {
            return new WonderWoman();
        }
    }
}
