using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Interview.Models;
using Newtonsoft.Json;
using Microsoft.Data.SqlClient;
using System.Data;


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


        // GET: api/MyofficeAcpd
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MyofficeAcpd>>> GetMyofficeAcpds()
        {
            try
            {
                return await _interviewContext.MyofficeAcpds
                .FromSqlRaw("EXEC GetAllMyoffice_ACPD")
                .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while Get MyofficeAcpd");
                return StatusCode(500, "An error occurred while processing your request.");
            }
            
        }

        /// <summary>
        /// �s�W
        /// </summary>
        /// <param name="myofficeAcpd"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(MyofficeAcpd myofficeAcpd)
        {
            try
            {
                // �নJson�榡
                string jsonData = JsonConvert.SerializeObject(myofficeAcpd);

                // �ϥΰѼƤƬd�ߩI�s�s�x�L�{
                var jsonParam = new SqlParameter("@JSON_Data", System.Data.SqlDbType.NVarChar)
                {
                    Value = jsonData
                };

                await _interviewContext.Database.ExecuteSqlRawAsync("EXEC InsertMyoffice_ACPD_FromJSON @JSON_Data", jsonParam);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating MyofficeAcpd");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        
    }
}