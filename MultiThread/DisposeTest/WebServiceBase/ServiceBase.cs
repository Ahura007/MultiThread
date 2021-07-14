using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisposeTest.WebServiceBase
{
    public class ServiceBase : System.Web.Services.WebService, IDisposable
    {
        public new void Dispose()
        {

            var t =GC.GetTotalMemory(true);

            var g= GC.CollectionCount(0);


            Dispose(true);
            GC.SuppressFinalize(this);

            var tt = GC.GetTotalMemory(true);
            var gg = GC.CollectionCount(0);

        }

        protected virtual void Dispose(bool disposing)
        {
        }
    }
}