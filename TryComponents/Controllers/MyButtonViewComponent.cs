using Microsoft.AspNetCore.Mvc;

namespace TryComponents.Controllers;

public enum MyButtonType 
{
    Primary,
    Secondary,
    Success
}


public class MyButtonViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(MyButtonType type, string title)
    {
        ViewBag.Title = title;
        return View(type);
    }
}
