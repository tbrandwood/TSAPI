using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TSAPI.Controllers.ExtensionMethods
{
    public static class HttpExtensions
    {

        public static string GetApiKey(this HttpRequest request)
        {
            if (!request.Headers.ContainsKey("Authorisation"))
                throw new SecurityException("Autorisation header not found in request");
                
            return request.Headers["Authorisation"];
        }
    }
}
