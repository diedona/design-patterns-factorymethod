using DDona.DesignPatterns.Factory.Domain.Enums;
using DDona.DesignPatterns.Factory.Domain.Factories.Base;
using DDona.DesignPatterns.Factory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.Factory.Domain.Factories
{
    public class HeroFactory
    {
        private readonly Dictionary<ESituationType, HeroFactoryBase> _factories;

        public HeroFactory()
        {
            _factories = new Dictionary<ESituationType, HeroFactoryBase>()
            {
                { ESituationType.Intelligence, new WonderWomanFactory() },
                { ESituationType.Stealth, new BatmanFactory() },
                { ESituationType.Strength, new SupermanFactory() }
            };
        }
    }
}
