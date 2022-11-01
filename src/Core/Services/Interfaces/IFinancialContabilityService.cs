using System.Threading.Tasks;

namespace Core.Services.Interfaces
{
    public interface IFinancialContabilityService
    {
        Task<double> CalculateTotalPriceAsync(int installments, double valueInstallments);
        Task<string> GetNameByIdAsync(int id);
    }
}
