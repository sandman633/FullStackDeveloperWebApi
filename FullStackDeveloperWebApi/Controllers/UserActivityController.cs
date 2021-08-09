using AutoMapper;
using FullStackDeveloperWebApi.Dto;
using FullStackDeveloperWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackDeveloperWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserActivityController : ControllerBase
    {

        private readonly ILogger<UserActivityController> _logger;
        private readonly IUserActivityService _service;
        private readonly IMapper _mapper;

        public UserActivityController(ILogger<UserActivityController> logger,IUserActivityService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserActivityDto>))]
        public async Task<IActionResult> Get()
        {
            _logger.LogInformation("UserActivity/Get was requested.");
            var responce = await _service.GetAsync();
            if(responce is IEnumerable<UserActivityDto>)
            {
                return Ok(responce);
            }
            return NotFound();
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public  IActionResult NewUser(IEnumerable<UserActivityDto> request)
        {
            _logger.LogInformation("UserActivity/Post was requested.");
            _service.CreateRange(request.ToArray());
            return Ok();
        }
    }
}
