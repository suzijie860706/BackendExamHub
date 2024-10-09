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
        /// 新增
        /// </summary>
        /// <param name="myofficeAcpd"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(MyofficeAcpd myofficeAcpd)
        {
            try
            {
                // 轉成Json格式
                string jsonData = JsonConvert.SerializeObject(myofficeAcpd);

                // 使用參數化查詢呼叫存儲過程
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