using CreationalDesignPatterns.Builder.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Builder.Domain
{
    public class SuperHero
    {
        public string Name { get; set; }
        public string CreatedYear { get; set; }
        public PublishingCompany PublishingCompany { get; set; }
        public Powers Powers { get; set; }
        public Weapons Weapons { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Created Year: {CreatedYear}");
            Console.WriteLine($"Publishing Company: {PublishingCompany}");
            if (Powers != 0)
            {
                Console.WriteLine($"Powers: {Powers}");
            }
            Console.WriteLine($"Weapons: {Weapons}");
            Console.WriteLine();
        }
    }
}
