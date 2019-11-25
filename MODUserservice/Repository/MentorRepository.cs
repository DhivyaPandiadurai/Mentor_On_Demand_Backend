using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MODUserservice.Context;
using MODUserservice.Models;

namespace MODUserservice.Repository
{
    public class MentorRepository : IMentorRepository
    {
        private readonly MainContext _context;
        public MentorRepository(MainContext context)
        {
            _context = context;
        }
        public List<Mentor> GetAll()
        {
            return _context.mentors.ToList();
        }
        public void AddMentor(Mentor item)
        {
            _context.mentors.Add(item);
            _context.SaveChanges();
        }

        public void BlockMentor(long id)
        {
            var item = _context.mentors.Find(id);
            if (item.Active == true)
            {
                item.Active = !(item.Active);
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void UnBlockMentor(long id)
        {
            var item = _context.mentors.Find(id);
            if (item.Active == false)
            {
                item.Active = !(item.Active);
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }


        public void DeleteMentor(long id)
        {
            var item = _context.mentors.Find(id);
            _context.mentors.Remove(item);
            _context.SaveChanges();
        }

        public Mentor GetMentorById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMentor(Mentor item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
