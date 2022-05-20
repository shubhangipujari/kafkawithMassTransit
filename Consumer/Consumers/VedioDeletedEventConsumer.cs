using Consumer.Events;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consumer.Consumers
{
    public class VedioDeletedEventConsumer:IConsumer<VedioDeletedEvents>
    {
        public Task Consume(ConsumeContext<VedioDeletedEvents> context)
        {
            var message = context.Message.Title;
            return Task.CompletedTask;
        }
    }
}
