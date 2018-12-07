using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context
{
    public class InvoiceDbContext : DbContext
    {
        public InvoiceDbContext(DbContextOptions<InvoiceDbContext> options)
            : base(options)
        {

        }

        public DbSet<InvoiceMaster> InvoiceMaster { get; set; }
        public DbSet<ParameterMaster> ParameterMaster { get; set; }
        public DbSet<RuleDetails> RuleDetails { get; set; }

    }
}
