using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net;
using TicketSale.CrossCutting.Exceptions;

namespace TicketSale.CrossCutting.Helper
{
    public class ExceptionHelper
    {
        private readonly RequestDelegate _next;

        public ExceptionHelper(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                await HandleException(context, e);
            }
        }
        private static Task HandleException(HttpContext context, Exception exception)
        {
            HttpStatusCode code;
            object response = exception.Message;

            switch (exception)
            {
                case ValidateEntityException _:
                    code = HttpStatusCode.BadRequest;
                    response = new ErrorMessage(exception.Message,"ValidateError");
                    break;

                case NotFoundException _:
                    code = HttpStatusCode.NotFound;
                    response = new ErrorMessage(exception.Message, "NotFound");
                    break;

                default:
                    code = HttpStatusCode.InternalServerError;
                    response = new ErrorMessage($"Erro: {exception.Message}","Internal Error");
                    break;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = Convert.ToInt32(code);

            return context.Response.WriteAsync(JsonConvert.SerializeObject(response, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }));
        }


    }
}
