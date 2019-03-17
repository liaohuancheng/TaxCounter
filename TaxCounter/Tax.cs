using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCounter
{
    public abstract class Tax
    {
        protected decimal TaxRate = 0;

        protected decimal QuickDeduction = 0;

        public virtual decimal Calculate(decimal income)
        {
            return income * TaxRate - QuickDeduction;
        }
    }
}
