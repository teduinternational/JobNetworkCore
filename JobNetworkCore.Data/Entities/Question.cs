using JobNetworkCore.Data.Enums;
using JobNetworkCore.Data.Interfaces;
using JobNetworkCore.Infrastructure.SharedKernel;
using System;

namespace JobNetworkCore.Data.Entities
{
    public class Question : DomainEntity<int>, IDateTracking, IHasOwner<string>, IMultiLanguage<string>, IHasSeoMetaData, ISortable
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Thumbnail { get; set; }

        public int SortOrder { set; get; }
        public bool ShowHome { set; get; }

        public DisplayLayout DisplayLayout { set; get; }

        public virtual AppUser Owner { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public string OwnerId { set; get; }
        public string LanguageId { set; get; }
        public virtual Language Language { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }
        public string SeoPageTitle { set; get; }
    }
}