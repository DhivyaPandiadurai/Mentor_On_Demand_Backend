using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TechnologyService.Models;
using MOD.TechnologyService.Repository;

namespace MOD.TechnologyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        private readonly ITechnologyRepository _repository;




        public TechnologyController(ITechnologyRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Technology
        [HttpGet]
        [Route("GetTechnology")]
        public List<Technology> get()
        {
            return _repository.GetAll();
        }




        public Technology Get(long id)
        {
           return  _repository.GetById(id);
         
        }

        //// GET: api/Technology/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Technology
        [HttpPost]
        [Route("AddSkill")]
        public IActionResult Post([FromBody] Technology item)
        {
            _repository.AddSkill(item);
            return Ok();

        }

        // PUT: api/Technology/5
        [HttpPut("{id}")]
        [Route("UpdateSkill")]
        public IActionResult Put( [FromBody] Technology item)
        {
            _repository.UpdateSkill(item);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
