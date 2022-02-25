using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EA.WebAPI.Filters
{
    public class IsExistAttribute : TypeFilterAttribute
    {
        public IsExistAttribute():base(typeof(IsExistsFilter))
        {

        }
    }
}
