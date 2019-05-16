using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCourse.Spyshop.Domain.Catalog
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public string Name { get; set; }

        public DateTime? DateTimeCreated { get; set; }
        public string CreatedByUsername { get; set; }

        public DateTime? DateTimeLastUpdated { get; set; }
        public string LastUpdatedByUsername { get; set; }

        public DateTime? DateTimeDeleted { get; set; }
        public string DeletedByUsername { get; set; }

        public bool IsDeleted { get; set; }


    }
}
