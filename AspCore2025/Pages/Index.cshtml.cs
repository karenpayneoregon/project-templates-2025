using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;
using System.Xml.Linq;

namespace AspCore2025.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public bool IsChecked { get; set; }
        public IndexModel()
        {
            Log.Information("Greetings");
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostButton1(IFormCollection data)
        {

            return new RedirectToPageResult("About");
        }
    }
}
