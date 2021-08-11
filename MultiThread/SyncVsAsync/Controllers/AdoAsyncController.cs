using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SyncVsAsync.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdoAsyncController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AdoAsyncController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<string> GetAsync()
        {
            var cs = _configuration.GetConnectionString("ConnectionStrings");
            await using var con = new SqlConnection(cs);
            var q = "insert into Teachers (TeacherName) values (@TeacherName)";
            await con.OpenAsync();
            await using var cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@TeacherName", Guid.NewGuid().ToString());
            await cmd.ExecuteNonQueryAsync();
            return "Hello";
        }


        [HttpPost]
        public async Task<string> PostAsync()
        {
            var cs = _configuration.GetConnectionString("ConnectionStrings");
            await using var con = new SqlConnection(cs);
            var q = "insert into Teachers (TeacherName) values (@TeacherName)";
            await con.OpenAsync();
            await using var cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@TeacherName", Guid.NewGuid().ToString());
            await cmd.ExecuteNonQueryAsync();
            return "Hello";
        }
    }
}