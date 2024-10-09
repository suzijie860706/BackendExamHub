using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Interview.Models;

namespace Project_Interview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        //
        private readonly InterviewContext _interviewContext;

        public UserController(ILogger<UserController> logger, InterviewContext interviewContext)
        {
            _logger = logger;
            _interviewContext = interviewContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost("Create")]
        public IActionResult Create(MyofficeAcpd myofficeAcpd)
        {
            _interviewContext.Database.ExecuteSqlInterpolated($@"
                EXEC GetMyoffice_ACPD 
                {myofficeAcpd.AcpdSid},
                {myofficeAcpd.AcpdCname},
                {myofficeAcpd.AcpdEname},
                {myofficeAcpd.AcpdSname},
                {myofficeAcpd.AcpdEmail},
                {myofficeAcpd.AcpdStatus},
                {myofficeAcpd.AcpdStop},
                {myofficeAcpd.AcpdStopMemo},
                {myofficeAcpd.AcpdLoginId},
                {myofficeAcpd.AcpdLoginPw},
                {myofficeAcpd.AcpdStopMemo},
                {myofficeAcpd.AcpdNowdatetime},
                {myofficeAcpd.AppdNowid},
                {myofficeAcpd.AcpdUpddatetitme},
                {myofficeAcpd.AcpdUpdid},
                ");
            return Ok();
        }
    }
}
