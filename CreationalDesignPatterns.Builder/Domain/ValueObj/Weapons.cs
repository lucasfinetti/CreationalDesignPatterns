using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Builder.Domain.ValueObj
{
    [Flags]
    public enum Weapons
    {
        Gun = 1,
        Armor = 2,
        Knife = 4,
        Axe = 8,
        Shield = 16
    }
}
