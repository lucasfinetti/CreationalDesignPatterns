using CreationalDesignPatterns.FactoryMethod.Services.ValueObj;
using CreationalDesignPatterns.FactoryMethod.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryMethod.Services.Factory
{
    public static class InsuranceFactory
    {
        public static IInsurance Create(InsuranceType insuranceType)
        {
            switch (insuranceType)
            {
                case InsuranceType.Car:
                    return new CarInsurance();
                case InsuranceType.CellPhone:
                    return new CellPhoneInsurance();
                case InsuranceType.House:
                    return new HouseInsurance();
                case InsuranceType.Motorcycle: 
                    return new MotorcycleInsurance();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
