using JobNetworkCore.Data.Interfaces;
using JobNetworkCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobNetworkCore.Data.Entities
{
    public class CandidateResume : DomainEntity<int>, ISortable, IDateTracking

    {
        public string CandidateId { get; set; }

        public Candidate Candidate { get; set; }

        public string ResumeUrl { get; set; }

        public string Note { get; set; }

        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
