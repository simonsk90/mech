using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mech.Pages;

public class TestModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public TestModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}