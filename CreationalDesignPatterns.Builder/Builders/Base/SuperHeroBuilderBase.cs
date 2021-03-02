using CreationalDesignPatterns.Builder.Domain;
using CreationalDesignPatterns.Builder.Domain.ValueObj;

namespace CreationalDesignPatterns.Builder.Builders.Base
{
    public abstract class SuperHeroBuilderBase
    {
        protected SuperHero SuperHero = null;

        public SuperHero GetSuperHero()
        {
            return SuperHero;
        }

        public void SetPublishingCompany(PublishingCompany publishingCompany)
        {
            this.SuperHero.PublishingCompany = publishingCompany;
        }

        protected void Init()
        {
            SuperHero = new SuperHero();
        }
    }
}
