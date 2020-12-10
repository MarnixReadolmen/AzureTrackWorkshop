using Microsoft.Azure.CognitiveServices.Vision;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;

[assembly: FunctionsStartup(typeof(RMotownFestival.Functions.Startup))]
namespace RMotownFestival.Functions
{
    class Startup: FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            FunctionsHostBuilderContext context = builder.GetContext();
            builder.Services.AddSingleton(p => new ComputerVisionClient(
                new ApiKeyServiceClientCredentials(context.Configuration.GetValue<string>("ComputerVisionApiKey")))
            {
                Endpoint = context.Configuration.GetValue<string>("ComputerVisionEndpoint")
            });

        }
    }
}
