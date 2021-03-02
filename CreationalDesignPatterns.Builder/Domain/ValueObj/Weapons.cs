using System;

namespace CreationalDesignPatterns.Builder.Domain.ValueObj
{
    [Flags]
    public enum Weapons
    {
        Armor = 1,
        Gun = 2,
        Bow = 4,
        Knife = 8,
        Axe = 16,
        Shield = 32
    }
}
