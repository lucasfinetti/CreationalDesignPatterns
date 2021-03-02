using CreationalDesignPatterns.AbstractFactory.Domain.Models;
using CreationalDesignPatterns.AbstractFactory.Domain.Interfaces;
using CreationalDesignPatterns.AbstractFactory.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactory.Services.Factories
{
    public sealed class ImmobilizedFactory : IInsuranceFactory
    {
        public InsuranceBase Create(Enum insuranceType)
        {
            var immobilizedType = (ImmobilizedType)insuranceType;

            switch (immobilizedType)
            {
                case ImmobilizedType.House:
                    return new HouseInsurance();
                case ImmobilizedType.Office:
                    return new OfficeInsurance();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
