using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeThiChang070.Models;

namespace LeThiChang070.Data
{
    public class LeThiChang070Context : DbContext
    {
        public LeThiChang070Context (DbContextOptions<LeThiChang070Context> options)
            : base(options)
        {
        }

        public DbSet<LeThiChang070.Models.PersonLTC070> PersonLTC070 { get; set; }
    }
}
