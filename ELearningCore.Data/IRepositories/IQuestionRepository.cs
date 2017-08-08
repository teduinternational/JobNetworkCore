using ELearningCore.Data.Entities;
using ELearningCore.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELearningCore.Data.IRepositories
{
    public interface IQuestionRepository : IRepository<Question, int>
    {
    }

}
