using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SyncVsAsync.Model;

namespace SyncVsAsync.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdoSyncController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AdoSyncController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public string Post()
        {
            var cs = _configuration.GetConnectionString("ConnectionStrings");
            using var con = new SqlConnection(cs);
            var q = "insert into Teachers (TeacherName) values (@TeacherName)";
            con.Open();
            using var cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@TeacherName", Guid.NewGuid().ToString());
            cmd.ExecuteNonQuery();
            return "Hello";
        }
    }
}