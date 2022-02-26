using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GreatTables.Models;

namespace GreatTables.Data
{
    public class GreatTablesContext : DbContext
    {
        public GreatTablesContext (DbContextOptions<GreatTablesContext> options)
            : base(options)
        {
        }

        public DbSet<GreatTables.Models.Table> Table { get; set; }
    }
}
