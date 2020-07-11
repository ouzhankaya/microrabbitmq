using System;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace MicroRabbit.Transfer.Data.Context
{
  public class TransferDBContext : DbContext
  {
    public TransferDBContext(DbContextOptions<TransferDBContext> options) : base(options)
    {
    }

    public DbSet<TransferLog> TransferLogs { get; set; }
  }
}
