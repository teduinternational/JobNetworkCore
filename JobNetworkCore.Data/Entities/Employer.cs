using JobNetworkCore.Data.Interfaces;
using JobNetworkCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using JobNetworkCore.Infrastructure.Enums;

namespace JobNetworkCore.Data.Entities
{
    public class Employer : DomainEntity<int>, IDateTracking, 
        IHasSeoMetaData, ISortable, ISwitchable,
        IHasSoftDelete
    {
        public string Name { get; set; }

        public string ShortDesc { set; get; }

        public string Logo { get; set; }

        public string Address { set; get; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public int SortOrder { get; set; }
        public Status Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}
