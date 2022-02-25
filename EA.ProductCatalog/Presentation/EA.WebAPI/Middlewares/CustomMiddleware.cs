using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EA.WebAPI.Middlewares
{
    public class CustomMiddleware
    {
        private RequestDelegate next;

        public CustomMiddleware(RequestDelegate requestDelegate)
        {
            this.next = requestDelegate;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Method == "POST")
            {
                httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                return;
            }
            await next.Invoke(httpContext);
        }
    }
}
