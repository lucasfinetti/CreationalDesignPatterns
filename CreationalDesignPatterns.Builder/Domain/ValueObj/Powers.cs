using System;

namespace CreationalDesignPatterns.Builder.Domain.ValueObj
{
    [Flags]
    public enum Powers
    {
        SuperStrength = 1,
        Fly = 2,
        Supervision = 4,
        Intelligence = 8,
        SuperSpeed = 16,
        Rich = 32,
        Fight = 64,
        Thunder = 128
    }
}
