using CreationalDesignPatterns.AbstractFactory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactory.Domain.Interfaces
{
    public interface IInsuranceFactory
    {
        public InsuranceBase Create(Enum insuranceType);
    }
}
