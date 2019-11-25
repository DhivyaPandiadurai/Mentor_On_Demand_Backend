using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TrainingService.Models;
using MOD.TrainingService.Repository;

namespace MOD.TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepository _repository;




        public TrainingController(ITrainingRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Training
        [HttpGet]
        [Route("GetAllTraining")]

        public List<Training> Get()
        {
            return _repository.GetAll();
        }

        //// GET: api/Training/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Training
        [HttpPost]
        [Route("AddTraining")]
        public IActionResult Post([FromBody] Training item)
        {
            _repository.AddTraining(item);
            return Ok();
        }

        [HttpGet("{id}", Name = "Get")]
        [Route("GetTrainingByUser/{id}")]
        public List<Training> Get(long id)
        {
            return _repository.GetTrainingByUserId(id);
        }

        [HttpGet("{id}", Name = "Get")]
        [Route("GetTrainingByMentor/{id}")]
        public List<Training> GetbyMentor(long id)
        {
            return _repository.GetTrainingByMentorId(id);

        }
        // PUT: api/Training/5
        [HttpPut("{id}")]
        [Route("UpdateTraining")]
        public IActionResult Put( [FromBody] Training item)
        {
            _repository.UpdateTraining(item);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
