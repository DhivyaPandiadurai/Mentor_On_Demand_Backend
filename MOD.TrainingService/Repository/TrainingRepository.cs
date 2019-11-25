using MOD.TrainingService.Context;
using MOD.TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Repository
{
    public class TrainingRepository:ITrainingRepository
    {
        private readonly TrainingContext _context;
        public TrainingRepository(TrainingContext context)
        {
            _context = context;
        }
        public List<Training> GetAll()
        {
            return _context.training.ToList();
        }

        public void AddTraining(Training item)
        {
            _context.training.Add(item);
            _context.SaveChanges();
        }

        public void UpdateTraining(Training item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public List<Training> GetTrainingByUserId(long id)
        {
            return _context.training.Where(i => i.Uid == id).ToList();

        }
        public List<Training> GetTrainingByMentorId(long id)
        {
            return _context.training.Where(i => i.Mid == id).ToList();

        }
    }
}
