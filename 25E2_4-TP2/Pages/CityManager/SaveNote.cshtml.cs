using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _25E2_4_TP2.Pages.CityManager;

public class SaveNote : PageModel
{

    public class InputModel
    {
        public string Content { set; get; }
        
        
    }
    public void OnGet()
    {
        
    }
}