using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCounter
{
    class Level0:Tax
    {
        public Level0()
        {
            TaxRate = 0.00m;
            QuickDeduction = 0;
        }
    }
}
