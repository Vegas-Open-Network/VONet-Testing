using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VONetTesting.Pages
{
    public class IndexModel : PageModel
    {
        public IReadOnlyList<string> Features { get; private set; } = new List<string>();

        public void OnGet()
        {
            Features = new[]
            {
                "Fast",
                "Secure",
                "Easy to use"
            };
        }
    }
}
