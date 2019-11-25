using MOD.TechnologyService.Context;
using MOD.TechnologyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TechnologyService.Repository
{
    public class TechnologyRepository:ITechnologyRepository
    {
          private readonly TechnologyContext _context;
            public TechnologyRepository(TechnologyContext context)
            {
                _context = context;
            }
        public List<Technology> GetAll()
        {
            return _context.technology.ToList();
        }



        public void AddSkill(Technology item)
        {
            _context.technology.Add(item);
            _context.SaveChanges();
        }

        
       public void UpdateSkill(Technology item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public Technology GetById(long id)
        {
            return _context.technology.Find(id);
        }
    }
}
