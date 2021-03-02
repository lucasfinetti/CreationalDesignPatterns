using CreationalDesignPatterns.Singleton.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Singleton.Repositoy
{
    public sealed class SuperHeroRepositoryLock
    {
        private readonly IList<SuperHeroModel> _superheros;
        private static SuperHeroRepositoryLock _instance = null;
        private static readonly object SyncObj = new object();

        private SuperHeroRepositoryLock()
        {
            _superheros = new List<SuperHeroModel>();
        }

        public static SuperHeroRepositoryLock GetInstance
        {
            get
            {
                if (_instance != null) return _instance;

                lock (SyncObj)
                {
                    if (_instance == null)
                    {
                        _instance = new SuperHeroRepositoryLock();
                    }
                }

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
