using Microsoft.EntityFrameworkCore.ChangeTracking;
using Quizer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Quizer.Core.Repositories.Special
{
    public class IQuestionRepository : IRepository<Question>
    {
        public Question Add(Question entity)
        {
            throw new NotImplementedException();
        }

        public Question Edit(Question entity, EntityEntry<Question> rules = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Question> GetAll(Expression<Func<Question, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Question GetFirst(Expression<Func<Question, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(Question entity)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }
    }
}
