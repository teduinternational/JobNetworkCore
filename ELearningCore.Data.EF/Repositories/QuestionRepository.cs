using ELearningCore.Data.Entities;
using ELearningCore.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELearningCore.Data.EF.Repositories
{
    public class QuestionRepository : EFRepository<Question, int>, IQuestionRepository
    {
        public QuestionRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
