using JobNetworkCore.Data.Interfaces;
using JobNetworkCore.Infrastructure.Enums;
using JobNetworkCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobNetworkCore.Data.Entities
{
    public class Language : DomainEntity<string>, ISwitchable
    {
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Resources { get; set; }

        public Status Status { get; set; }
    }
}
