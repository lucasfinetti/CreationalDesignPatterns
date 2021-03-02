using CreationalDesignPatterns.Singleton.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Singleton.Repositoy
{
    public sealed class SuperHeroRepository
    {
        private readonly IList<SuperHeroModel> _superheros;
        private static SuperHeroRepository _instance = null;

        private SuperHeroRepository()
        {
            _superheros = new List<SuperHeroModel>();
        }

        public static SuperHeroRepository GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new SuperHeroRepository();

                return _instance;
            }
        }

        public IList<SuperHeroModel> GetAll()
        {
            return _instance._superheros;
        }

        public void Insert(SuperHeroModel superhero)
        {
            _instance._superheros.Add(superhero);
        }
    }
}
