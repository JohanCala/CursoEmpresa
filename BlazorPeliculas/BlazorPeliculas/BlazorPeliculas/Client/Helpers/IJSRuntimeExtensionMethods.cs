using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("Console.log", "Prubea Console log");
            return await js.InvokeAsync<bool>("confirm", message);
        }
    }
}
