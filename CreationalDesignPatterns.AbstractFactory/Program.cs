using CreationalDesignPatterns.AbstractFactory.Domain.ValueObj;
using CreationalDesignPatterns.AbstractFactory.Services.AbstractFactory;
using System;

namespace CreationalDesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobilizedfactory = InsuranceAbstractFactory.CreateFactory(InsuranceType.Mobilized);
            var immobilizedfactory = InsuranceAbstractFactory.CreateFactory(InsuranceType.Immobilized);

            var carInsurance = mobilizedfactory.Create(MobilizedType.Car);
            var cellPhoneInsurance = mobilizedfactory.Create(MobilizedType.CellPhone);
            var motorcycleInsurance = mobilizedfactory.Create(MobilizedType.Motorcycle);
            var houseInsurance = immobilizedfactory.Create(ImmobilizedType.House);
            var officeInsurance = immobilizedfactory.Create(ImmobilizedType.Office);

            var carInsurancePolicy = carInsurance.AuthorizeInsurance();
            Console.WriteLine($"Car insurance policy: {carInsurancePolicy}");

            var cellPhoneInsurancePolicy = cellPhoneInsurance.AuthorizeInsurance();
            Console.WriteLine($"Cell Phone insurance policy: {cellPhoneInsurancePolicy}");

            var houseInsurancePolicy = houseInsurance.AuthorizeInsurance();
            Console.WriteLine($"House insurance policy: {houseInsurancePolicy}");

            var motorcycleInsurancePolicy = motorcycleInsurance.AuthorizeInsurance();
            Console.WriteLine($"Motorcycle insurance policy: {motorcycleInsurancePolicy}");

            var officeInsurancePolicy = officeInsurance.AuthorizeInsurance();
            Console.WriteLine($"Office insurance policy: {officeInsurancePolicy}");
        }
    }
}
