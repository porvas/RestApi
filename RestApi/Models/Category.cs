using System.Collections.Generic;

namespace RestApi.API.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Subcategory> Subcategories { get; set; }

        public Category()
        {
            this.Subcategories = new List<Subcategory>();
        }
    }
}