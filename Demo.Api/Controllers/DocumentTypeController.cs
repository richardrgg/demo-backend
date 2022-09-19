using Demo.Queries.DocumentType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentTypeController : ControllerBase
    {
        private readonly IDocumenTypeQueries _documenTypeQueries;

        public DocumentTypeController(IDocumenTypeQueries documenTypeQueries)
        {
            _documenTypeQueries = documenTypeQueries ?? throw new ArgumentNullException(nameof(documenTypeQueries));
        }


        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _documenTypeQueries.GetAll();
            return Ok(result);
        }
    }
}
