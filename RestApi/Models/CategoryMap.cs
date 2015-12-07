using RestApi.API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;


public class CategoryMap : EntityTypeConfiguration<Category>
{
    public CategoryMap()
    {
        this.HasKey(t => t.Id);

        HasMany(t => t.Subcategories)
            .WithRequired()
            .HasForeignKey(t => t.CategoryId);
    }
}
