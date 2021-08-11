using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SyncVsAsync.Context;
using SyncVsAsync.Model;

namespace SyncVsAsync.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EfAsyncController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public EfAsyncController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<List<Teacher>> GetAsync()
        {
            var all = await _dbContext.Teachers.ToListAsync();
            return all;
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync()
        {
            var t = new Teacher
            {
                TeacherName = Guid.NewGuid().ToString()
            };
            await _dbContext.Teachers.AddAsync(t);
            await _dbContext.SaveChangesAsync();
            return Ok(t);
        }
    }
}