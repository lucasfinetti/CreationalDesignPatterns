using CreationalDesignPatterns.FactoryMethod.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryMethod.Services
{
    public class CellPhoneInsurance : IInsurance
    {
        public Guid AuthorizeInsurance()
        {
            return Guid.NewGuid();
        }
    }
}
