using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MIC.Volo.PFM.EFCore
{
    class PFMDbContext:DbContext
    {
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }

    public class Wallet
    {
        public int WalletId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Day { get; set; }
        public DateTime Timestamp { get; set; }
        public string Comment { get; set; }

        public int CategorytId { get; set; }
        public Category Category;
    }

    public class Category
    {
        public int CategorytId { get; set; }
        public String Title { get; set; }

        public List<Wallet> wallets;
    }
}
