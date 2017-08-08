using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ELearningCore.Data.EF
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Languages.Any())
            {
                return;
            }


            context.SaveChanges();
        }
    }
}
