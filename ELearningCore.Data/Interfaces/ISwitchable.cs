using ELearningCore.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELearningCore.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
