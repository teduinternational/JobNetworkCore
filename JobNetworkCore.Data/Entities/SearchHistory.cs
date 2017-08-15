using JobNetworkCore.Data.Interfaces;
using JobNetworkCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobNetworkCore.Data.Entities
{
    public class SearchHistory : DomainEntity<int>, IDateTracking
    {
        public string Name { set; get; }
        public string Alias { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
    }
}
