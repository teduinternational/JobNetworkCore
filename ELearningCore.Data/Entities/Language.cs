using ELearningCore.Data.Interfaces;
using ELearningCore.Infrastructure.Enums;
using ELearningCore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELearningCore.Data.Entities
{
    public class Language : DomainEntity<string>, ISwitchable
    {
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Resources { get; set; }

        public Status Status { get; set; }
    }
}
