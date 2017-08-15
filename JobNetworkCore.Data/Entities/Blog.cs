using JobNetworkCore.Data.Interfaces;
using JobNetworkCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using JobNetworkCore.Infrastructure.Enums;

namespace JobNetworkCore.Data.Entities
{
    public class Blog : DomainEntity<int>, IDateTracking, IHasOwner<string>, IHasSeoMetaData, ISortable, ISwitchable
    {
        public string Title { get; set; }
        public string ShortDesc { get; set; }
        public string Image { set; get; }

        public string Content { get; set; }
        public int ViewCount { set; get; }

        public bool? HotStatus { get; set; }

        public string OwnerId { get; set; }
        public AppUser Owner { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public int SortOrder { get; set; }
        public Status Status { get; set; }
    }
}
