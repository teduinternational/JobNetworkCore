using JobNetworkCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobNetworkCore.Data.Entities
{
    public class JobTechnology : DomainEntity<int>
    {
        public string TechnologyId { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
        public Technology Technology { get; set; }
    }
}
