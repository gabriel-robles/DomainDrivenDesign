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

        var app = builder
                    .ConfigureServices()
                    .ConfigurePipeline();

        app.Run();
    }
}