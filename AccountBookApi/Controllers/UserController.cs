using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AccountBookApi.Domain;
using AccountBookApi.Data.Repository.Interfaces;
using System.Threading.Tasks;
using AccountBookApi.DTO;
using AutoMapper;

namespace AccountBookApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<AccountBookController> _logger;
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;
        public UserController(ILogger<AccountBookController> logger, IRepository<User> repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("{Id}", Name = "Get")]
        public async Task<ActionResult<User>> Get(Guid Id)
        {
            var Message = $"GetAllUsers triggered at {DateTime.UtcNow.ToLongTimeString()}";
            _logger.LogInformation(Message);
            var data = await _repository.GetByIdAsync(Id);
            return Ok(_mapper.Map<GetUserDTO>(data));
        }


        [HttpGet("GetAll", Name = "GetAll")]
        public async Task<ActionResult<IEnumerable<User>>> GetAll()
        {
            // var Message = $"GetAll triggered at {DateTime.UtcNow.ToLongTimeString()}";
            // _logger.LogInformation(Message);
            var data = await _repository.ListAllAsync();
            return Ok(_mapper.Map<IEnumerable<GetUserDTO>>(data));
        }

        [HttpPost(Name = "Create")]
        public async Task<IActionResult> Create(CreateUserDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            await _repository.AddAsync(user);
            var result = _mapper.Map<GetUserDTO>(user);
            return CreatedAtRoute("Get", new { Id = result.Id }, result);
        }

        [HttpDelete("{Id}", Name = "DeleteUser")]
        public async Task<IActionResult> Delete(Guid Id)
        {
            await _repository.DeleteAsync(Id);
            return NoContent();
        }

        [HttpOptions]
        public IActionResult GetUserOptions()
        {
            Response.Headers.Add("Allow", "Get,POST,OPTIONS,PUT,DELETE");
            return Ok();
        }
    }
}
