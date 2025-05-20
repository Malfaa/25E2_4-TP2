using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _25E2_4_TP2.Pages.CityManager;

public class SaveNote : PageModel
{

    [BindProperty]
    public InputModel Input { get; set; }
    public string Download { get; set; }

    public class InputModel
    {
        public string Content { set; get; }
    }
    
    public void OnPost()
    {
        var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");
        Directory.CreateDirectory(folderPath);
        
        var timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
        var fileName = $"note-{timestamp}.txt";
        var fullPath = Path.Combine(folderPath, fileName);
        
        System.IO.File.WriteAllText(fullPath, Input.Content);
        Download = $"/files/{fileName}";

    }
    public void OnGet()
    {
        
    }
}