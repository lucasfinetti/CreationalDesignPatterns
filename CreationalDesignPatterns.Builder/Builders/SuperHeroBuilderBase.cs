using CreationalDesignPatterns.Builder.Domain;
using CreationalDesignPatterns.Builder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Builder.Builders
{
    public abstract class SuperHeroBuilderBase
    {
        protected SuperHero SuperHero = null;
        protected readonly ISuperHeroService _superHeroService;

        protected SuperHeroBuilderBase(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        public int GetPowerPoints()
        {
            return _superHeroService.GetPowerPoints(SuperHero);
        }

        public void DefineClass()
        {
            _superHeroService.DefineClass(SuperHero);
        }

        public SuperHero Get()
        {
            return SuperHero;
        }

        protected void Init()
        {
            SuperHero = new SuperHero();
        }
    }
}
