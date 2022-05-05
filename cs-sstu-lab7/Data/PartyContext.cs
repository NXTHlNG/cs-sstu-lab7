#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cs_sstu_lab7.Models;

namespace cs_sstu_lab7.Data
{
    public class PartyContext : DbContext
    {
        public PartyContext (DbContextOptions<PartyContext> options)
            : base(options)
        {
        }

        public DbSet<cs_sstu_lab7.Models.PartyMember> PartyMember { get; set; }
    }
}
