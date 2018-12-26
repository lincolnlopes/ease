using System;
using Ease.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Ease.Infra.Data.Context
{
    public class EaseContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public EaseContext(DbContextOptions options) : base(options)
        {

        }
    }
}
