using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCounter
{
    class Level1:Tax
    {
        public Level1()
        {
            TaxRate = 0.03m;
            QuickDeduction = 0;

        }
    }
}
