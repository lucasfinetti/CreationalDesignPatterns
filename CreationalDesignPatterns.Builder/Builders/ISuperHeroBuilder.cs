using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Builder.Builders
{
    interface ISuperHeroBuilder
    {
        void AddPowers();
        void AddWeapons();
        void DefineClass();
        void GetSuperHero();
    }
}
