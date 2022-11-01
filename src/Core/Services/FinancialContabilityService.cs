using Core.Models.Exceptions;
using Core.Services.Interfaces;
using Core.Services.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Services
{
    public class FinancialContabilityService : IFinancialContabilityService
    {
        private const double INTEREST_RATES = 0.05;
        public async Task<double> CalculateTotalPriceAsync(int installments, double valueInstallments)
        {
            if (installments == 0)
                throw new InvalidNumberOfInstallmentsException();

            var productValue = CalculateValue(installments, valueInstallments);
            var feesValue = CalculateValue(productValue, INTEREST_RATES);

            var totalValue = productValue + feesValue;

            return totalValue;
        }

        private static double CalculateValue(double firstValue, double secondValue)
        {
            return MathOperations.MultipliesValue(firstValue, secondValue);
        }

        public async Task<string> GetNameByIdAsync(int id)
        {
            if (id == 0)
                throw new InvalidIdException();

            var genericValues = GenericValues();

            var indexById = genericValues.First(f => f.Key == id);

            return indexById.Value;
        }

        private static List<KeyValuePair<int, string>> GenericValues()
        {
            return new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(1, "João"),
                new KeyValuePair<int, string>(2, "Maria"),
                new KeyValuePair<int, string>(3, "Ana"),
            };
        }
    }
}
