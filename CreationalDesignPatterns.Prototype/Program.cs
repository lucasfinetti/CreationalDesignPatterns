using CreationalDesignPatterns.Prototype.Models;
using System;

namespace CreationalDesignPatterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSuperHero = new SuperHero
            {
                Name = "Batman",
                PublisedYear = "1978",
                PublishingCompany = new PublishingCompany()
                {
                    Name = "DC Comics",
                    Founder = "Malcolm Wheeler-Nicholson"
                }
            };

            var secondSuperHero = firstSuperHero;
            var thirdSuperHero = firstSuperHero.ShallowCopy();
            var fourthSuperHero = firstSuperHero.DeepCopy();

            Print("No copy method, first hero", firstSuperHero);

            firstSuperHero.Name = "Iron Man";
            firstSuperHero.PublisedYear = "1970";
            firstSuperHero.PublishingCompany.Name = "Marvel Comics";
            firstSuperHero.PublishingCompany.Founder = "Martin Goodman";

            Print("Simple Copy (=)", secondSuperHero);
            Print("Shallow Copy", thirdSuperHero);
            Print("Deep Copy", fourthSuperHero);

            Console.ReadKey();
        }

        static void Print(string copyMethod, SuperHero superHero)
        {
            Console.WriteLine($"Copy Method: {copyMethod}");
            Console.WriteLine($"Name: {superHero.Name}");
            Console.WriteLine($"Publised Year: {superHero.PublisedYear}");
            Console.WriteLine($"Publishing Company Name: {superHero.PublishingCompany.Name}");
            Console.WriteLine($"Publishing Company Founder: {superHero.PublishingCompany.Founder}");
            Console.WriteLine();
        }
    }
}
