using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.FactoryMethod.Services.Interfaces
{
    public interface IInsurance
    {
        Guid AuthorizeInsurance();
    }
}
