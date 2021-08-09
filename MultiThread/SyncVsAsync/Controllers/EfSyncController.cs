using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SyncVsAsync.Context;
using SyncVsAsync.Model;

namespace SyncVsAsync.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EfSyncController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public EfSyncController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public List<Teacher> Get()
        {
            var all = _dbContext.Teachers.ToList();
            return all;
        }

        [HttpPost]
        public ActionResult Post()
        {
            var t = new Teacher
            {
                TeacherName = Guid.NewGuid().ToString()
            };
            _dbContext.Teachers.Add(t);
            _dbContext.SaveChanges();
            return Ok(t);
        }
    }
}