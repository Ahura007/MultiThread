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
    public class SyncController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SyncController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public string Get()
        {
            var cs = _configuration.GetConnectionString("ConnectionStrings");
            using var con = new SqlConnection(cs);
            using var cmd = new SqlCommand("GetAllStudent", con);

            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            using var rdr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rdr);

            return "Hello";
        }
    }
}