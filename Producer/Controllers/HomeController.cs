using MassTransit.KafkaIntegration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Producer.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Producer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private ITopicProducer<VedioDeletedEvents> _topicProducer;
        public HomeController(ITopicProducer<VedioDeletedEvents> topicProducer)
        {
            _topicProducer = topicProducer;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]string title)
        {
            await _topicProducer.Produce(new VedioDeletedEvents { Title = title });
            return Ok(title);
        }
    }
}
