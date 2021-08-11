using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace PrismApp.Controllers
{
    public class AsyncController : ApiController
    {
        public Task<List<string>> GetAsync()
        {
            return Task.Run(() => Task.FromResult(Data()));
        }

        private List<string> Data()
        {
            Thread.Sleep(2000);
            return new List<string>()
            {
                "1", "2"
            };
        }
    }
}
