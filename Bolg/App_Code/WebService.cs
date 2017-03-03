using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Bolg.App_Code
{
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(int a, int b)
        {
            int result = a + b;
            return result.ToString();
        }
    }

    
}