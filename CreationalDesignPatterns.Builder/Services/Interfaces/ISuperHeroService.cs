using CreationalDesignPatterns.Builder.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Builder.Services.Interfaces
{
    public interface ISuperHeroService
    {
        int GetPowerPoints(SuperHero superHero);
        void DefineClass(SuperHero superHero);
    }
}
