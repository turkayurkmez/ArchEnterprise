using EA.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EA.WebAPI.Filters
{
    public class IsExistsFilter : IAsyncActionFilter
    {
        private readonly IProductService productService;

        public IsExistsFilter(IProductService productService)
        {
            this.productService = productService;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var id = context.ActionArguments["id"];
            int entityId = (int)id;
            var isPositive = entityId > 0 && await productService.IsProductExists(entityId);

            if (!isPositive)
            {
                context.Result = new NotFoundObjectResult(entityId);
                return;
            }

            await next();
        }
    }
}
