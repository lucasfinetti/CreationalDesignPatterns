using CreationalDesignPatterns.FactoryMethod.Services.ValueObj;
using CreationalDesignPatterns.FactoryMethod.Services.Factory;
using System;

namespace CreationalDesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var carInsurance = InsuranceFactory.Create(InsuranceType.Car);
            var carInsurancePolicy = carInsurance.AuthorizeInsurance();
            Console.WriteLine($"Car insurance policy: {carInsurancePolicy}");

            var cellPhoneInsurance = InsuranceFactory.Create(InsuranceType.CellPhone);
            var cellPhoneInsurancePolicy = cellPhoneInsurance.AuthorizeInsurance();
            Console.WriteLine($"Cell Phone insurance policy: {cellPhoneInsurancePolicy}");

            var houseInsurance = InsuranceFactory.Create(InsuranceType.House);
            var houseInsurancePolicy = houseInsurance.AuthorizeInsurance();
            Console.WriteLine($"House insurance policy: {houseInsurancePolicy}");

            var motorcycleInsurance = InsuranceFactory.Create(InsuranceType.Motorcycle);
            var motorcycleInsurancePolicy = motorcycleInsurance.AuthorizeInsurance();
            Console.WriteLine($"Motorcycle insurance policy: {motorcycleInsurancePolicy}");

            Console.ReadKey();
        }
    }
}
