using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODUserservice.Models;
using MODUserservice.Repository;

namespace MODUserservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _repository;
        public MentorController(IMentorRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Mentor
        [HttpGet]
        [Route("GetAllMentor")]
        public List<Mentor> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Mentor/5
        [HttpGet("{id}", Name = "Get")]
        [Route("GetById/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Mentor
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Mentor item)
        {
            _repository.AddMentor(item);
            return Ok("Record Added");
        }

        // PUT: api/Mentor/5
        [HttpPut("{id}")]
        [Route("Update")]

        public void Put([FromBody]Mentor item)
        {
            _repository.UpdateMentor(item);
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(long id)
        {
            _repository.DeleteMentor(id);
        }
        [HttpPut("{id}")]
        [Route("BlockMentor/{id}")]
        public void Block(long id)
        {
            _repository.BlockMentor(id);
        }
        [HttpPut("{id}")]
        [Route("UnBlockMentor/{id}")]
        public void UnBlock(long id)
        {
            _repository.UnBlockMentor(id);
        }
    }
}
