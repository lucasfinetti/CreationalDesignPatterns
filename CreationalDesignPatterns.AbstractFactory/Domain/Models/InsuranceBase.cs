using CreationalDesignPatterns.AbstractFactory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactory.Domain.Models
{
    public abstract class InsuranceBase : IInsurance
    {
        public Guid AuthorizeInsurance()
        {
            return Guid.NewGuid();
        }
    }
}
