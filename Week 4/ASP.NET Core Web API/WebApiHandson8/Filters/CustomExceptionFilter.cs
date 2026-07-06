using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiHandson8.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string errorMessage = context.Exception.Message;

            File.AppendAllText(
                "error_log.txt",
                $"{DateTime.Now}: {errorMessage}{Environment.NewLine}"
            );

            context.Result = new ObjectResult("Internal Server Error")
            {
                StatusCode = 500
            };
        }
    }
}