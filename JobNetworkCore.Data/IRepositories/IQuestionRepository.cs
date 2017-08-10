using JobNetworkCore.Data.Entities;
using JobNetworkCore.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobNetworkCore.Data.IRepositories
{
    public interface IQuestionRepository : IRepository<Question, int>
    {
    }

}
