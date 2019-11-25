using MODUserservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MODUserservice.Repository
{
   public interface IUserRepository
    {
        void AddUser(User item);
        void DeleteUser(long id);
        void BlockUser(long id);
        void UnBlockUser(long id);
        User GetById(int id);
        List<User> GetAll();
        void UpdatePassword(User item);
        //void UpdateDetails(User item);
        List<Mentor> SearchMentor(string Skill);
    }
}
