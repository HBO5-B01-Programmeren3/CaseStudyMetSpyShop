using System.Collections.Generic;

namespace CoreCourse.Spyshop.Domain.Catalog
{
    public class Category : BaseEntity<long>
    {
        public ICollection<Product> Products { get; set; }
    }
    
}
