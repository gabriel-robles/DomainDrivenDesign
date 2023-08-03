namespace App.Api;

/// <summary>
///     Injeta as dependências da camada de apresentação da aplicação.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    ///     Adiciona os serviços no <see cref="IServiceCollection"/> designado.
    /// </summary>
    /// <param name="services">sem os serviços.</param>
    /// <returns>com os serviços.</returns>
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
}