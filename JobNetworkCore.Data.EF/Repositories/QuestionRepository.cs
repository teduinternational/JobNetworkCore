using JobNetworkCore.Data.Entities;
using JobNetworkCore.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobNetworkCore.Data.EF.Repositories
{
    public class QuestionRepository : EFRepository<Question, int>, IQuestionRepository
    {
        public QuestionRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
