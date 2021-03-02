using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.AbstractFactory.Domain.Interfaces
{
    public interface IInsurance
    {
        Guid AuthorizeInsurance();
    }
}
