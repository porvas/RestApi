using RestApi.API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;


public class SubcategoryMap : EntityTypeConfiguration<Subcategory>
{
    public SubcategoryMap()
    {
        this.HasKey(t => t.Id);
    }
}
