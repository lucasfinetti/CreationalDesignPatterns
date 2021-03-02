using CreationalDesignPatterns.Builder.Builders.Interface;
using CreationalDesignPatterns.Builder.Domain.ValueObj;

namespace CreationalDesignPatterns.Builder.Director
{
    public class SuperHeroCreator
    {
        public void CreateDCSuperHero(ISuperHeroBuilder builder)
        {
            builder.InitHero();
            builder.SetWeaponsAndPowers();
            builder.SetPublishingCompany(PublishingCompany.DC);
        }

        public void CreateMarvelSuperHero(ISuperHeroBuilder builder)
        {
            builder.InitHero();
            builder.SetWeaponsAndPowers();
            builder.SetPublishingCompany(PublishingCompany.Marvel);
        }
    }
}
