using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _25E2_4_TP2.Pages.CityManager;

public class LoadNote : PageModel
{
    public string[] Arquivos { get; set; }
    public string ConteudoArquivo { get; set; }
    
    public IActionResult OnGet(string? file = null)
    {
        if (ModelState.IsValid)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");
            Arquivos = Directory.GetFiles(path);
        
            if (file != null)
            {
                ConteudoArquivo = System.IO.File.ReadAllText(Path.Combine(path, file));
            }
        }

        return Page();
    }
}