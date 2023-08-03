using Serilog;

namespace App.Api;

/// <summary>
///     Classe de entrada da aplicação.
/// </summary>
internal static class Program
{
    /// <summary>
    ///     Método de entrada da aplicação.
    /// </summary>
    /// <param name="args">argumentos usado na inicialização da aplicação.</param>
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Host.UseSerilog();

        Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(builder.Configuration)
                    .CreateLogger();

        try
        {
            var app = builder
                        .ConfigureServices()
                        .ConfigurePipeline();

            app.Run();
        }
        catch (Exception ex)
        {
            Log.Fatal("{Action} {@Exception}", "A Aplicação encerrou inesperadamente.", ex);
            throw;
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}