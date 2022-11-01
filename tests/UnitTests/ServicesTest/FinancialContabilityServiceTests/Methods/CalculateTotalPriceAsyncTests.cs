using Core.Models.Exceptions;
using System.Threading.Tasks;
using Xunit;

namespace ServicesTest.FinancialContabilityServiceTests.Methods
{
    public class CalculateTotalPriceAsyncTests : FinancialContabilityServiceTests
    {
        [Fact]
        private async Task CorrectParameters_ReturnValueCalculated()
        {
            #region Arrange
            var fakeInstallments = 5;
            var fakeValueInstallments = 10;
            var fakeTotalPrice = 52.5;
            #endregion

            //Act
            var result = await _sut.CalculateTotalPriceAsync(fakeInstallments, fakeValueInstallments);

            //Assert
            Assert.Equal(result, fakeTotalPrice);
        }

        [Fact]
        private async Task InstallmentsIsZero_ThrowInvalidNumberOfInstallmentsException()
        {
            #region Arrange
            var fakeInstallments = 0;
            var fakeValueInstallments = 10;

            Task responseCalculateTotalPriceAsync() => _sut.CalculateTotalPriceAsync(fakeInstallments, fakeValueInstallments);
            #endregion

            //Act
            var exception = await Assert.ThrowsAsync<InvalidNumberOfInstallmentsException>(responseCalculateTotalPriceAsync);

            //Assert
            Assert.Equal("Invalid number of installments.", exception.Message);

        }
    }
}
