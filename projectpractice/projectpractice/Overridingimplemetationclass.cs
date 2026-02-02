using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal class Overridingimplemetationclass : OverridingExample
    {
        // for overhide remove overide and virtual key word from parent class
        override public double calculatebill(int amount)
        {
            return amount + amount * 0.18F;
        }

    }
}
