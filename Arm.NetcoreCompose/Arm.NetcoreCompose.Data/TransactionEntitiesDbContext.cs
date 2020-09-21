using System;
using System.Collections.Generic;
using System.Text;
using Arm.NetcoreCompose.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Arm.NetcoreCompose.Data
{
    public class TransactionEntitiesDbContext : DbContext
    {
        public TransactionEntitiesDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<TransactionEntity> Transactions { get; set; }

        public DbSet<TransactionStatusEntity> TransactionStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionEntity>().HasOne(entity => entity.Status).WithMany().HasForeignKey(x => x.StatusId);
        }
    }
}
