using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchedulerServiceContract;

namespace SchedulerApi.Controllers.V1
{
    [Route("api/v1/attendees"), ApiController]
    public class AttendeeController : BaseController
    {
        private readonly IAttendeeService _attendeeService;

        public AttendeeController(IAttendeeService attendeeService, IMapper mapper) : base(mapper)
        {
            _attendeeService = attendeeService;
        }
    }
}
