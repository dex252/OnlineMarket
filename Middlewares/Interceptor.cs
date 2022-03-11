using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using OnlineMarket.Exceptions;

namespace OnlineMarket.Middlewares
{
    public class Interceptor
    {
        public static IActionResult Get(ActionContext context)
        {
            var errors = context.ModelState.Values.SelectMany(e => e.Errors)
                .Select(e => e.ErrorMessage);

            var firstError = errors.FirstOrDefault();
            var json = JsonConvert.SerializeObject(context.ModelState.Values);

            throw new ValidationException(firstError, json);
        }
    }
}
