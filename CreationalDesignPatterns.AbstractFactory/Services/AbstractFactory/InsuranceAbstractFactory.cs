using CreationalDesignPatterns.AbstractFactory.Domain.Models;
using CreationalDesignPatterns.AbstractFactory.Services.Factories;
using CreationalDesignPatterns.AbstractFactory.Domain.Interfaces;
using CreationalDesignPatterns.AbstractFactory.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactory.Services.AbstractFactory
{
    public static class InsuranceAbstractFactory
    {
        public static IInsuranceFactory CreateFactory(InsuranceType insuranceType)
        {
            switch (insuranceType)
            {
                case InsuranceType.Immobilized:
                    return new ImmobilizedFactory();
                case InsuranceType.Mobilized:
                    return new MobilizedFactory();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
