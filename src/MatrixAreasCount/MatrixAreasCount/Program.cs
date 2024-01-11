using MatrixAreasCount;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = CreateHostBuilder(args).Build();

using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;

try
{
    services.GetRequiredService<App>().Run();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

HostApplicationBuilder CreateHostBuilder(string[] args)
{
    var builder = Host.CreateApplicationBuilder(args);

    builder.Services
        .AddScoped<IMatrixParser, MatrixParser>()
        .AddScoped<IMatrixAreasCalculator, MatrixAreasCalculator>()
        .AddSingleton<App>();

    return builder;
}
