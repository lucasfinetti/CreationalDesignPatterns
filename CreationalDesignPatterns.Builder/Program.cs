using CreationalDesignPatterns.Builder.Builders;
using CreationalDesignPatterns.Builder.Director;
using System;

namespace CreationalDesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var superHeroCreator = new SuperHeroCreator();

            var batmanBuilder = new BatmanBuilder();
            var ironManBuilder = new IronManBuilder();
            var thorBuilder = new ThorBuilder();

            superHeroCreator.CreateDCSuperHero(batmanBuilder);
            superHeroCreator.CreateMarvelSuperHero(ironManBuilder);
            superHeroCreator.CreateMarvelSuperHero(thorBuilder);

            var batman = batmanBuilder.GetSuperHero();
            var thor = thorBuilder.GetSuperHero();
            var ironMan = ironManBuilder.GetSuperHero();

            batman.ShowInfo();
            thor.ShowInfo();
            ironMan.ShowInfo();
        }
    }
}
