using Core.Models.Exceptions;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class FinancialContabilityController : ControllerBase
    {
        private readonly IFinancialContabilityService _financialContabilityService;

        public FinancialContabilityController(IFinancialContabilityService financialContabilityService)
        {
            _financialContabilityService = financialContabilityService;
        }

        [HttpPost]
        [Route("financial/calculate")]
        public async Task<IActionResult> CalculateTotalPriceAsync([FromHeader] int installments, [FromHeader] double valueInstallments)
        {
            try
            {
                var totalValue = await _financialContabilityService.CalculateTotalPriceAsync(installments, valueInstallments);
                return Ok(totalValue.ToString("F"));
            }
            catch(InvalidNumberOfInstallmentsException ix)
            {
                return BadRequest(ix.Message);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        [Route("financial/name")]
        public async Task<IActionResult> GetNameById([FromHeader] int id)
        {
            try
            {
                var name = await _financialContabilityService.GetNameByIdAsync(id);
                return Ok(name);
            }
            catch (InvalidIdException ix)
            {
                return BadRequest(ix.Message);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
