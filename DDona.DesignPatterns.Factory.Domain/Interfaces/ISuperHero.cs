using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.FactoryMethod.Domain.Interfaces
{
    public interface ISuperHero
    {
        string HeroName { get; }
        string GetDescription();
    }
}
