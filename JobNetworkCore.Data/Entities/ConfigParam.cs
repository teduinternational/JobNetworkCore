﻿using JobNetworkCore.Data.Interfaces;
using JobNetworkCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using JobNetworkCore.Infrastructure.Enums;

namespace JobNetworkCore.Data.Entities
{
    public class ConfigParam : DomainEntity<string>, ISwitchable
    {
        public string Name { get; set; }

        public string Value1 { get; set; }
        public int? Value2 { get; set; }

        public bool? Value3 { get; set; }

        public DateTime? Value4 { get; set; }

        public decimal? Value5 { get; set; }
        public Status Status { get; set; }
    }
}
