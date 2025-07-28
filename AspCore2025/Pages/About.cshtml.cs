using Microsoft.AspNetCore.Mvc.RazorPages;
using Spectre.Console;

namespace AspCore2025.Pages
{
    public class AboutModel : PageModel
    {
        public void OnGet()
        {
            AnsiConsole.MarkupLine("[bold cyan]Welcome to the About page![/]");
        }
    }
}
