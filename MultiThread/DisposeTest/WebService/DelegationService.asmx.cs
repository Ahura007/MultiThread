using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DisposeTest.Models;
using DisposeTest.WebServiceBase;

namespace DisposeTest.WebService
{
    /// <summary>
    /// Summary description for DelegationService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    [System.Web.Script.Services.ScriptService]
    public class DelegationService : ServiceBase
    {
        [WebMethod]
        public string HelloWorld()
        {
            for (int i = 0; i < 1000; i++)
            {
                var text = new People();
            }
            return "Hello World";
        }
    }
}
