using Microsoft.JSInterop;

namespace Blazor.Demo.Styles;

public class DemoJsInterop : IAsyncDisposable
{
	private readonly Lazy<Task<IJSObjectReference>> moduleTask;

	public DemoJsInterop(IJSRuntime jsRuntime)
	{
		this.moduleTask = new Lazy<Task<IJSObjectReference>>(() => jsRuntime.InvokeAsync<IJSObjectReference>(
			"import", "./_content/Blazor.Demo.Styles/exampleJsInterop.js").AsTask());
	}

	public async ValueTask DisposeAsync()
	{
		if (this.moduleTask.IsValueCreated)
		{
			IJSObjectReference module = await this.moduleTask.Value;
			await module.DisposeAsync();
		}
	}

	public async ValueTask<string> Prompt(string message)
	{
		IJSObjectReference module = await this.moduleTask.Value;
		return await module.InvokeAsync<string>("showPrompt", message);
	}
}
