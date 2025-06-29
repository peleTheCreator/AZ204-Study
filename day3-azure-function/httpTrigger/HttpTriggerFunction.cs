using System.Net;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

public class HttpTriggerFunction
{
    private readonly ILogger<HttpTriggerFunction> _logger;

    public HttpTriggerFunction(ILogger<HttpTriggerFunction> logger)
    {
        _logger = logger;
    }

    [Function(nameof(HttpTriggerFunction))]
    public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
    {
        _logger.LogInformation("message logged");

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
        await response.WriteStringAsync("Welcome to .NET isolated worker !!");

        return response;
    }
}
