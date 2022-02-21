using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Halloween_Party.Models;

namespace Halloween_Party.Data
{
    public class Halloween_PartyContext : DbContext
    {
        public Halloween_PartyContext (DbContextOptions<Halloween_PartyContext> options)
            : base(options)
        {
        }

        public DbSet<Halloween_Party.Models.Guest> Guest { get; set; }
    }
}
