using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MODUserservice.Context;
using MODUserservice.Models;

namespace MODUserservice.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MainContext _context;
        public UserRepository(MainContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.users.ToList();
        }
        public void AddUser(User item)
        {
            _context.users.Add(item);
            _context.SaveChanges();
        }

        public void BlockUser(long id)
        {
            var item = _context.users.Find(id);
            if (item.Active == true)
            {
                item.Active = !(item.Active);
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void UnBlockUser(long id)
        {
            var item = _context.users.Find(id);
            if (item.Active == false)
            {
                item.Active = !(item.Active);
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }


        public void DeleteUser(long id)
        {
            var item = _context.users.Find(id);
            _context.users.Remove(item);
            _context.SaveChanges(); 
        }

        public User GetById(int id)
        {
            return _context.users.Find(id);
        }

        public List<Mentor> SearchMentor(string Skill)
        {
            return _context.mentors.Where(i => i.Primary_skill == Skill).ToList();
        }

        public void UpdatePassword(User item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
