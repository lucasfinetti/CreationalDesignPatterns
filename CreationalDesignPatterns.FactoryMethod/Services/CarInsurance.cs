using CreationalDesignPatterns.FactoryMethod.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryMethod.Services
{
    public class CarInsurance : IInsurance
    {
        public Guid AuthorizeInsurance()
        {
            return Guid.NewGuid();
        }
    }
}
