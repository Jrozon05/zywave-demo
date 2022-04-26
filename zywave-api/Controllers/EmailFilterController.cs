using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using zywave_data.Interfaces;

namespace zywave_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailFilterController : ControllerBase
    {
        private readonly IEmailFilterService _service;
        private readonly IConfiguration _config;

        public EmailFilterController(IEmailFilterService service, IConfiguration config)
        {
            _service = service;
            _config = config;
        }

        [HttpPost]
        public IActionResult ClassifiedEmailFilter(string emailText)
        {
            var classifiedWords = _config.GetSection("Classified:Words").Get<List<string>>();
            var emailFiltered = _service.FilterEmail(classifiedWords, emailText);
            
            return Ok(emailFiltered);
        }
    }
}