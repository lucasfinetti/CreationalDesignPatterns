using CreationalDesignPatterns.Builder.Builders.Base;
using CreationalDesignPatterns.Builder.Builders.Interface;
using CreationalDesignPatterns.Builder.Domain.ValueObj;

namespace CreationalDesignPatterns.Builder.Builders
{
    public sealed class ThorBuilder : SuperHeroBuilderBase, ISuperHeroBuilder
    {
        public void InitHero()
        {
            this.Init();
            this.SuperHero.Name = "Thor";
        }

        public void SetWeaponsAndPowers()
        {
            this.SuperHero.Powers = Powers.Thunder;

            this.SuperHero.Weapons = Weapons.Axe;
        }
    }
}