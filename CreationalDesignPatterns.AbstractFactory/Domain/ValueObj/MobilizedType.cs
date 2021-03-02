using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactory.Domain.ValueObj
{
    public enum MobilizedType
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
        /// Seguro de Moto - Motorcycle Insurance
        /// </summary>
        Motorcycle = 2
    }
}
