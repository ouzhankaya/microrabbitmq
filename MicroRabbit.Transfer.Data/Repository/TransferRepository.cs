using System;
using System.Collections.Generic;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Repository
{
  public class TransferRepository : ITransferRepository
  {

    private TransferDBContext _context;
    public TransferRepository(TransferDBContext context)
    {
      _context = context;
    }

    public void Add(TransferLog transferLog)
    {
      _context.Add(transferLog);
      _context.SaveChanges();
    }

    public IEnumerable<TransferLog> GetTransferLogs()
    {
      return _context.TransferLogs;
    }
  }
}
