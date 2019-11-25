using MOD.TechnologyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TechnologyService.Repository
{
   public interface ITechnologyRepository
    {
        void AddSkill(Technology item);
        List<Technology> GetAll();
        void UpdateSkill(Technology item);

        Technology GetById(long id);
    }
}
