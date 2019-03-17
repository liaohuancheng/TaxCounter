using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCounter
{
    class Level2:Tax
    {
        public Level2()
        {
            TaxRate = 0.10m;
            QuickDeduction = 210;
        }
    }
}
