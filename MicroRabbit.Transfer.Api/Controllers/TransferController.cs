using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroRabbit.Transfer.Api.Controllers
{
  [Route("api/[controller]")]
  public class TransferController : Controller
  {
    private readonly ITransferService _service;

    public TransferController(ITransferService service)
    {
      _service = service;
    }
    // GET: api/values
    [HttpGet]
    public ActionResult<IEnumerable<TransferLog>> Get()
    {
      return Ok(_service.GetTransferLogs());
    }

  }
}
