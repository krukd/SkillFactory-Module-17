using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_Module_17
{
    internal class Calculator
    {
        public static void CalculateInterest(IAccount account)
        {
            account.CalculateInterest();
        }
    }
}
