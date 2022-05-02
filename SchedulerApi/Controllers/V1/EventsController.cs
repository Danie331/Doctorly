using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchedulerServiceContract;

namespace SchedulerApi.Controllers.V1
{
    [Route("api/v1/events"), ApiController]
    public class EventsController : BaseController
    {
        private readonly IEventService _eventsService;

        public EventsController(IEventService eventsService, IMapper mapper) : base(mapper)
        {
            _eventsService = eventsService;
        }
    }
}
