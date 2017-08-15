using JobNetworkCore.Data.Entities;
using JobNetworkCore.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobNetworkCore.Data.EF.Repositories
{
    public class JobRepository : EFRepository<Job, int>, IJobRepository
    {
        public JobRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
