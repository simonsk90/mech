using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mech.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public static int Counter = 0; 

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Counter = 0;
    }

    public IActionResult OnPost()
    {
        Counter++;
        return Content($"<span>{Counter}</span>", "text/html");
    }
}
