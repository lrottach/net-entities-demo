using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .Build();

// Add http client to dependency injection
host.Services.AddHttpClient("AzureApiClient", configuration =>
        {
            configuration.BaseAddress = new Uri("https://management.azure.com/");
        });

host.Run();
