using JobNetworkCore.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobNetworkCore.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
