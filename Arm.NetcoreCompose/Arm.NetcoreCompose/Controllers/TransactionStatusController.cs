using System.Linq;
using Arm.NetcoreCompose.Data;
using Microsoft.AspNetCore.Mvc;

namespace Arm.NetcoreCompose.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionStatusController : ControllerBase
    {
        private readonly TransactionEntitiesDbContext dbContext;
        public TransactionStatusController(TransactionEntitiesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = dbContext.TransactionStatus.ToList();
            return new JsonResult(result);
        }
    }
}
