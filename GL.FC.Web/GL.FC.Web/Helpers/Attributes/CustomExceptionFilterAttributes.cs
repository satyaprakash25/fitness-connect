using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GL.FC.Web
{
    public class CustomExceptionFilterAttributes : ExceptionFilterAttribute
    {
        public CustomExceptionFilterAttributes()
        {

        }

        public override void OnException(ExceptionContext context)
        {
            base.OnException(context);
        }
    }
}
