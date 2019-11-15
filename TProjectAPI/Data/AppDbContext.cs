using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TProjectAPI.Models;

namespace TProjectAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=TProjectDB")
        {

        }
        public DbSet<People> People { get; set; }
    }
}