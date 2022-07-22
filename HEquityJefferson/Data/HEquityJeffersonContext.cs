using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HEquityJefferson.Model;

namespace HEquityJefferson.Data
{
    public class HEquityJeffersonContext : DbContext
    {
        public HEquityJeffersonContext (DbContextOptions<HEquityJeffersonContext> options)
            : base(options)
        {
        }

        public DbSet<HEquityJefferson.Model.Car> Car { get; set; }
    }
}
