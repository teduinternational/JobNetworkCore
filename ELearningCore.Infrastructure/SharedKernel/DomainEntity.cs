using System;
using System.Collections.Generic;
using System.Text;

namespace ELearningCore.Infrastructure.SharedKernel
{
    public abstract class DomainEntity<T>
    {
        /// <summary> 
        /// Gets or sets the unique ID of the entity in the underlying data store. 
        /// </summary> 
        public T Id { get; set; }

        /// <summary> 
        /// Checks if the current domain entity has an identity. 
        /// </summary> 
        /// <returns>True if the domain entity is transient (i.e. has no identity yet),
        /// false otherwise.
        /// </returns> 
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}
