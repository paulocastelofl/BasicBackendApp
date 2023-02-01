using GanEdenComex.Application.Models;
using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;

namespace GanEdenComex.Application.Middlewares
{
    public static class ServiceExtensions
    {
        public static void ConfigureExtensionHandler(this IApplicationBuilder app)
        {
            var ErrorVar = new Error

            {
                StatusCode = 500,
                Message = "Internal Server Error"
            };

            app.UseExceptionHandler(error =>
            {
                error.Run(async context =>
                {
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {

                        var inner = contextFeature.Error;
                        if (inner.InnerException != null)
                        {
                            var tipo = inner.InnerException.GetType().ToString();
                            if (tipo.Equals("System.Web.Http.HttpResponseException"))
                            {
                                var Httperror = (System.Web.Http.HttpResponseException)inner.InnerException;
                                context.Response.StatusCode = Convert.ToInt32(Httperror.Response.StatusCode);
                                ErrorVar.StatusCode = Convert.ToInt32(Httperror.Response.StatusCode);
                                ErrorVar.Message = inner.Message;
                            }

                            else if (tipo.Equals("System.AggregateException"))
                            {
                                var Httperror = (System.AggregateException)inner.InnerException;
                                ErrorVar.StatusCode = 400;
                                ErrorVar.Message = Httperror.Message;
                                context.Response.StatusCode = 400;
                                //context.Response.StatusCode = Convert.ToInt32(Httperror.Response.StatusCode);
                            }

                        }

                        else
                        {
                            ErrorVar.StatusCode = 500;
                            ErrorVar.Message = inner.Message;
                        }
                        //Log.Error($"error: {contextFeature.Error}");
                        await context.Response.WriteAsync(JsonConvert.SerializeObject(ErrorVar));
                    }
                });
            });
        }
    }
}
