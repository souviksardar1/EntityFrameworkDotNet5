using EntityFrameworkDotNet5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDotNet5.Contexts
{
    public class FurnitureDbContext : DbContext
    {
        public FurnitureDbContext(DbContextOptions<FurnitureDbContext> option) : base(option)
        {

        }

        DbSet<ApiDataModel> tbl_FurnitureData { get; set; }
    }
}
