namespace App.Api;

/// <summary>
///    Métodos de extensão para configurar os serviços e pipeline de request HTTP.
/// </summary>
internal static class HostingExtensions
{
    /// <summary>
    ///     Configura os serviços da aplicação.
    /// </summary>
    /// <param name="builder">sem os serviços configurados.</param>
    /// <returns>com os serviços configurados.</returns>
    internal static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddPresentation();

        return builder.Build();
    }

    /// <summary>
    ///     Configura o pipeline de request HTTP.
    /// </summary>
    /// <param name="app">sem o pipeline configurado.</param>
    /// <returns>com o pipeline configurado.</returns>
    internal static WebApplication ConfigurePipeline(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger(c => c.SerializeAsV2 = true);
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        return app;
    }
}