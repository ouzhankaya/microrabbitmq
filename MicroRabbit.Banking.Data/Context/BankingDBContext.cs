using System;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Context
{
  public class BankingDBContext : DbContext
  {
    public BankingDBContext(DbContextOptions<BankingDBContext> options) : base(options)
    {
    }

    public DbSet<Account> Accounts { get; set; }
  }
}
