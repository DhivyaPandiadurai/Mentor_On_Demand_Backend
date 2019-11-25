using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;
using MOD.TechnologyService.Models;
using MOD.TechnologyService.Repository;
using MOD.TechnologyService.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MOD_Test
{
    public class TechnologyTest
    {

        private readonly Mock<ITechnologyRepository> _repo;
        private readonly TechnologyController _controller;
        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetAll()).Returns(GetTechnologies());
            var result = _controller.get() as List<Technology>;
            Assert.Equal(3, result.Count);
        }


        [Fact]
       public void GetById()
        {
            _repo.Setup(m =>m.GetById(123)).Returns(GetTechnologies()[0]);
            var result = _controller.Get(123) as Technology;
            Assert.Equal(123,result.SkillId);
            Assert.NotNull(result);
        }
        public TechnologyTest()
        {
            _repo = new Mock<ITechnologyRepository>();
            _controller = new TechnologyController(_repo.Object);
        }

        private List<Technology> GetTechnologies()
        {
            return new List<Technology>()
            {
                new Technology(){SkillId=123,SkillName="Java"},
                new Technology(){SkillId=1234,SkillName="C++"},
                new Technology(){SkillId=12345,SkillName="Dotnet"}
            };


        }
        [Fact]
        public void Post()
        {
            var item = GetTechnologies()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Put()
        {

            var item = GetTechnologies()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);

        }
        


      

    }
}
