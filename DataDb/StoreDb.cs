using _057_haseeb._1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _057_haseeb._1.DataDb
{
    public class StoreDb : DbContext
    {
        public StoreDb(DbContextOptions<StoreDb> options) : base(options)
        {

        }
        public DbSet<OrderModel> orders { get; set; }
    }
}
