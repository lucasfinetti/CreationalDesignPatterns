using CreationalDesignPatterns.Singleton.Model;
using CreationalDesignPatterns.Singleton.Repositoy;
using System;

namespace CreationalDesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var superHeroRepository = SuperHeroRepositoryLock.GetInstance;

            var firstList = superHeroRepository.GetAll();

            superHeroRepository.Insert(new SuperHeroModel { Name = "Batman", PublishingCompany = "DC Comics" });
            superHeroRepository.Insert(new SuperHeroModel { Name = "Iron Man", PublishingCompany = "Marvel Comics" });

            var secondList = superHeroRepository.GetAll();

            var superHeroRepository2 = SuperHeroRepositoryLock.GetInstance;

            var thirdList = superHeroRepository2.GetAll();

            Console.WriteLine($"firstList == secondList: {firstList == secondList}");
            Console.WriteLine($"firstList == thirdList: {firstList == thirdList}");

            Console.ReadKey();
        }
    }
}
