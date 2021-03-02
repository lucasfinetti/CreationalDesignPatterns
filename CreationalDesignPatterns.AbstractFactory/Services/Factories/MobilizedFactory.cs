using CreationalDesignPatterns.AbstractFactory.Domain.Models;
using CreationalDesignPatterns.AbstractFactory.Domain.Interfaces;
using CreationalDesignPatterns.AbstractFactory.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactory.Services.Factories
{
    public sealed class MobilizedFactory : IInsuranceFactory
    {
        public InsuranceBase Create(Enum insuranceType)
        {
            var mobilizedType = (MobilizedType)insuranceType;

            switch (mobilizedType)
            {
                case MobilizedType.Car:
                    return new CarInsurance();
                case MobilizedType.CellPhone:
                    return new CellPhoneInsurance();
                case MobilizedType.Motorcycle:
                    return new MotorcycleInsurance();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
