﻿using JobNetworkCore.Data.Interfaces;
using JobNetworkCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using JobNetworkCore.Infrastructure.Enums;

namespace JobNetworkCore.Data.Entities
{
    public class Location : DomainEntity<int>, IHasSeoMetaData, ISortable, ISwitchable
    {
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public Status Status { get; set; }
    }
}
