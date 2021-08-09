using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SyncVsAsync.Model;

namespace SyncVsAsync.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AsyncController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AsyncController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<string> GetAsync()
        {
            try
            {
                var cs = _configuration.GetConnectionString("ConnectionStrings");
                await using var con = new SqlConnection(cs);
                await using var cmd = new SqlCommand("GetAllStudent", con);

                cmd.CommandType = CommandType.StoredProcedure;
                 
                await con.OpenAsync();
                await using var rdr = await cmd.ExecuteReaderAsync();
                var dt = new DataTable();
                dt.Load(rdr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
  

            return "Hello";
        }
    }
}