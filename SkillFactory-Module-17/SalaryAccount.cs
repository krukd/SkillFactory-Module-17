using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_Module_17
{
    internal class SalaryAccount : IAccount
    {
        public double Balance { get; set; }

        public double Interest { get; set; }

        public void CalculateInterest()
        {
            // расчет процентной ставки зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
        }
    }
}

