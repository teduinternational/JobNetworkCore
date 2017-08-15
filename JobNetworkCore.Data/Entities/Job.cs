using JobNetworkCore.Data.Interfaces;
using JobNetworkCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using JobNetworkCore.Infrastructure.Enums;

namespace JobNetworkCore.Data.Entities
{
    public class Job : DomainEntity<int>, IDateTracking, IHasOwner<string>,
        IHasSeoMetaData, ISortable, ISwitchable, IHasSoftDelete
    {
        public string Title { set; get; }
        public string ShortDesc { get; set; }

        public string Content { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string OwnerId { get; set; }
        public AppUser Owner { get; set; }
        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public int SortOrder { get; set; }
        public bool IsDeleted { get; set; }
    }
}
