using Htmx;
using Mech.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class DataController : Controller
{
    [HttpGet]
    public IActionResult GetData()
    {
        if (!Request.IsHtmx())
        {
            return null;
        }
        // Your logic to retrieve data
        var res = new MyViewModel()
        {
            Title = "Welcome to My MVC App",
            Message = "This is a message from the controller.",
            Items = new List<MyItem>
            {
                new MyItem { Name = "Item 1", Description = "Description for Item 111" },
                new MyItem { Name = "Item 2", Description = "Description for Item 2" },
                new MyItem { Name = "Item 3", Description = "Description for Item 3" }
            }
        };
        return View(res);
    }
}
