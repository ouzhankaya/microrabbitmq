using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroRabbit.Banking.Api.Controllers
{
  [Route("api/[controller]")]
  public class BankingController : Controller
  {

    private readonly IAccountService _accountService;

    public BankingController(IAccountService accountService)
    {
      _accountService = accountService;
    }
    // GET: api/Banking
    [HttpGet]
    public ActionResult <IEnumerable<Account>> Get()
    {
      return Ok(_accountService.GetAccounts());
    }

  }
}
