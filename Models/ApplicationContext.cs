using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practise.Models
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Record> Records { get; set; }

        public DbSet<Status> Statuses { get; set; }
    }
}
