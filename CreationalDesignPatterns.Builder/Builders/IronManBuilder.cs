using CreationalDesignPatterns.Builder.Builders.Base;
using CreationalDesignPatterns.Builder.Builders.Interface;
using CreationalDesignPatterns.Builder.Domain.ValueObj;

namespace CreationalDesignPatterns.Builder.Builders
{
    public sealed class IronManBuilder : SuperHeroBuilderBase, ISuperHeroBuilder
    {
        public void InitHero()
        {
            this.Init();
            this.SuperHero.Name = "IronMan";
        }

        public void SetWeaponsAndPowers()
        {
            this.SuperHero.Weapons = Weapons.Armor | Weapons.Gun;
        }
    }
}