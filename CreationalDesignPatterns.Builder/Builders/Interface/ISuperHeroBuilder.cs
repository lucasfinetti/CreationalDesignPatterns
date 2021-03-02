using CreationalDesignPatterns.Builder.Domain;
using CreationalDesignPatterns.Builder.Domain.ValueObj;

namespace CreationalDesignPatterns.Builder.Builders.Interface
{
    public interface ISuperHeroBuilder
    {
        void InitHero();
        void SetWeaponsAndPowers();
        void SetPublishingCompany(PublishingCompany publishingCompany);
        SuperHero GetSuperHero();
    }
}
