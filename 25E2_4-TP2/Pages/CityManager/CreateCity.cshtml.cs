using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _25E2_4_TP2.Pages.CityManager;

public class CreateCity : PageModel
{
    [BindProperty]
    public InputModel Input { get; set; } = new();
    public class InputModel
    {
        [Required(ErrorMessage = "Nome é obrigatório.")]
        [MinLength(3, ErrorMessage="Tamanho mínimo de 3 caracteres")]
        public string CityName {get; set;} = string.Empty;
    }
    
    
    public void OnPost()
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine($"Cidade: {Input.CityName}");
        }
        else
        {
            Console.WriteLine($"Cidade com nome inválido. Mínimo: 3 caracteres");
        }
    }

    public void OnGet()
    {
        
    }
}