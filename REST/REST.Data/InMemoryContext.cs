using Microsoft.EntityFrameworkCore;
using REST.Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace REST.Data
{
    public class InMemoryContext : DbContext
    {
        public InMemoryContext()
        {
        }

        public InMemoryContext(DbContextOptions<InMemoryContext> options) : base(options)
        {

        }

        public DbSet<CalculatorHistory> CalculatorInMemoryHistory { get; set; }

    }
}
