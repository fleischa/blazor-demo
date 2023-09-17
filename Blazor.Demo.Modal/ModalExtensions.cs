using Microsoft.Extensions.DependencyInjection;

namespace Blazor.Demo.Modal;

public static class ModalExtensions
{
	public static IServiceCollection AddModal(this IServiceCollection serviceCollection)
	{
		serviceCollection.AddSingleton<ModalService>();
		return serviceCollection;
	}
}