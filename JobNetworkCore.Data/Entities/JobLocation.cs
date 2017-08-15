using JobNetworkCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobNetworkCore.Data.Entities
{
    public class JobLocation : DomainEntity<int>
    {
        public int JobId { get; set; }
        public string LocationId { get; set; }

        public Job Job { get; set; }
        public Location Location { get; set; }
    }
}
