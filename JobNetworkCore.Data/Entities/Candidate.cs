using JobNetworkCore.Data.Interfaces;
using JobNetworkCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobNetworkCore.Data.Entities
{
    public class Candidate : DomainEntity<string>, IHasSoftDelete
    {
        public bool IsDeleted { get; set; }

    }
}
