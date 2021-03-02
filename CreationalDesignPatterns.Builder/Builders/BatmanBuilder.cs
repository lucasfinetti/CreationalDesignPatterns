using CreationalDesignPatterns.Builder.Builders.Base;
using CreationalDesignPatterns.Builder.Builders.Interface;
using CreationalDesignPatterns.Builder.Domain.ValueObj;

namespace CreationalDesignPatterns.Builder.Builders
{
    public sealed class BatmanBuilder : SuperHeroBuilderBase, ISuperHeroBuilder
    {
        public void InitHero()
        {
            this.Init();
            this.SuperHero.Name = "Batman";
        }

        public void SetWeaponsAndPowers()
        {
            this.SuperHero.Weapons = Weapons.Armor | Weapons.Gun;
        }
    }
}
