using Core.Services;
using Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.FinancialContabilityServiceTests
{
    public abstract class FinancialContabilityServiceTests
    {
        protected readonly IFinancialContabilityService _sut;
        public FinancialContabilityServiceTests()
        {
            _sut = new FinancialContabilityService();
        }
    }
}
