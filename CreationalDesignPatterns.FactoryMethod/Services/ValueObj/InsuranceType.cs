using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryMethod.Services.ValueObj
{
    public enum InsuranceType
    {
        /// <summary>
        /// Seguro de Carro - Car Insurance
        /// </summary>
        Car = 0,

        /// <summary>
        /// Seguro de Celular - Cell Phone Insurance
        /// </summary>
        CellPhone = 1,

        /// <summary>
        /// Seguro de Casa - House Insurance
        /// </summary>
        House = 2,

        /// <summary>
        /// Seguro de Moto - Motorcycle Insurance
        /// </summary>
        Motorcycle = 3
    }
}
