using CreationalDesignPatterns.Builder.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Builder.Domain
{
    public class SuperHero
    {
        public string Name { get; set; }
        public Class @class { get; set; }
        public Powers powers { get; set; }
        public Weapons Weapons { get; set; }
        public bool Car { get; set; }
    }
}
