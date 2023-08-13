using System.Diagnostics.CodeAnalysis;

namespace App.Api;

/// <summary>
/// Injeta as dependências da camada de apresentação da aplicação.
/// </summary>
[ExcludeFromCodeCoverage]
public static class DependencyInjection
{
    /// <summary>
    /// Adiciona os serviços no <see cref="IServiceCollection"/> designado.
    /// </summary>
    /// <param name="services">sem os serviços.</param>
    /// <returns></returns>
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
}