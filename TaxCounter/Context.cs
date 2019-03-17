using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCounter
{
    public class Context
    {

        private Tax tax = null;

        private const decimal EXEMPTION_VALUE = 5000m;

        private List<decimal> taxLevel = new List<decimal>{
        0,
        3000,
        12000,
        25000,
        35000,
        55000,
        80000,
        decimal.MaxValue
    };

        private List<Type> levels = new List<Type>();

        private void GetLevels()
        {
            levels = AppDomain.CurrentDomain.GetAssemblies()
                               .SelectMany(tp => tp.GetTypes()
                               .Where(t => t.BaseType == typeof(Tax)))
                               .ToList();
        }

        public Context()
        {
            GetLevels();
        }

        public decimal Calculate(decimal income)
        {
            tax = new Level0();
            for (int i = 1; i <= taxLevel.Count - 1; i++)
            {
                if (income > taxLevel[i - 1] && income <= taxLevel[i])
                {
                    tax = (Tax)Activator.CreateInstance(levels[i]);
                }
            }
            return tax.Calculate((decimal)income);

        }

    }

}
