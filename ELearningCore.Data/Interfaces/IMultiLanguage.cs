using ELearningCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELearningCore.Data.Interfaces
{
    public interface IMultiLanguage<T>
    {
        T LanguageId { set; get; }
        Language Language { set; get; }
    }
}
