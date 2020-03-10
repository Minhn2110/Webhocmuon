using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace webhocmuon.Models
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext() : base("MyConnectionString")
        {

        }

        public DbSet<Student> Games { get; set; }

    }
}