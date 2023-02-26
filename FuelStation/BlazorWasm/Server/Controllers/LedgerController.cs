using BlazorWasm.Shared.Items;
using BlazorWasm.Shared.Ledger;
using EF.Orm.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWasm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LedgerController : ControllerBase
    {
        private readonly LedgerRepo _ledgerRepo;
        public LedgerController(LedgerRepo ledgerRepo)
        {
            _ledgerRepo = ledgerRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<LedgerDto>> Get()
        {
            var result = _ledgerRepo.GetAll();
            return result.Select(ledger => new LedgerDto
            {
                Year = ledger.Year,
                Month = ledger.Month,
                Income = ledger.Income,
                Expenses = ledger.Expenses,
                Total = ledger.Total
            });
        }
    }
}
