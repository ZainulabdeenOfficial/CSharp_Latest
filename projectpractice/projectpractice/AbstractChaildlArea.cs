using System;
using System.Collections.Generic;
using System.Text;

namespace projectpractice
{
    internal class AbstractChaildlArea : AbstractClassExample
    {
        

        internal override void ractangle()
        {
            areas = param1 * param2;
        }

        internal override void traiangle()
        {
           areas = 0.5f * param1 * param2;
        }
    }
}
