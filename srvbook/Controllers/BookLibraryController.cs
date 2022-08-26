using Microsoft.AspNetCore.Mvc;

namespace srvbook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookLibraryController : ControllerBase
    {
        private readonly ILogger<BookLibraryController> _logger;

        public BookLibraryController(ILogger<BookLibraryController> logger)
        {
            _logger = logger;
        }

      //  [HttpGet]
        // public IEnumerable<Data> GetBookList()
        //      {

        //      }

      //  [HttpPut]

    }
}