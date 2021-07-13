using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace PrismApp.Controllers
{
    public class SyncController : ApiController
    {
        public IEnumerable<string> Get()
        {
            Thread.Sleep(2000);
            return new string[] { "1", "2" };
        }
    }
}