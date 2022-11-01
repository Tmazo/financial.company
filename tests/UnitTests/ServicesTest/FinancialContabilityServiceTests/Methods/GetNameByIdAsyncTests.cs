using Core.Models.Exceptions;
using System.Threading.Tasks;
using Xunit;

namespace ServicesTest.FinancialContabilityServiceTests.Methods
{
    public class GetNameByIdAsyncTests : FinancialContabilityServiceTests
    {
        [Fact]
        private async Task CorrectParametes_ReturnName()
        {
            #region Arrange
            var fakeId = 1;
            var fakeName = "João";
            #endregion

            //Act
            var result = await _sut.GetNameByIdAsync(fakeId);

            //Assert
            Assert.Equal(result, fakeName);
        }

        [Fact]
        private async Task IdIsZero_ThrowInvalidIdException()
        {
            #region Arrange
            var fakeId = 0;

            Task responseGetNameByIdAsync() => _sut.GetNameByIdAsync(fakeId);
            #endregion

            //Act
            var exception = await Assert.ThrowsAsync<InvalidIdException>(responseGetNameByIdAsync);

            //Assert
            Assert.Equal("Invalid number of id.", exception.Message);

        }
    }
}
