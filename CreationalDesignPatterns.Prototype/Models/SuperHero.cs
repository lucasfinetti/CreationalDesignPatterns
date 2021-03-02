using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Prototype.Models
{
    public class SuperHero
    {
        public string Name { get; set; }
        public string PublisedYear { get; set; }
        public PublishingCompany PublishingCompany { get; set; }

        public SuperHero ShallowCopy()
        {
            return (SuperHero)this.MemberwiseClone();
        }

        public SuperHero DeepCopy()
        {
            return new SuperHero
            {
                Name = this.Name,
                PublisedYear = this.PublisedYear,
                PublishingCompany = new PublishingCompany()
                {
                    Name = this.PublishingCompany.Name,
                    Founder = this.PublishingCompany.Founder,
                }
            };
        }
    }
}
