using System;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IOC
{
  public class DependencyContainer
  {
    public static void RegisterServices(IServiceCollection services)
    {
      services.AddTransient<IEventBus, RabbitMQBus>();
    }
  }
}
