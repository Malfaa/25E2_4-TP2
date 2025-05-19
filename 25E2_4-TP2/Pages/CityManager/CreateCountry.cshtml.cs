using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _25E2_4_TP2.Pages.CityManager;

public class CreateCountry : PageModel
{
    
    [BindProperty]
    public InputModel Input { get; set; }

    [BindProperty] 
    public List<InputModel> ListaInputs { get; set; } = new();

    public class InputModel //Faz a validação dos dados
    {
        [Required(ErrorMessage = "Nome necessário")]
        public string CountryName { set; get; }
        [Required(ErrorMessage = "Código necessário")]
        [StringLength(2, MinimumLength = 2)]
        public string CountryCode { set; get; }
    }

    public void OnPost()
    {
        
        if (ModelState.IsValid)
        {
            var country = Country.FromInputModel(Input);
            Console.WriteLine($"Nome país: {country.CountryName}\nCódigo país: {country.CountryCode}");
        }
    }
    
    public void OnGet()
    {
        for (int i = 0; i < 5; i++)
        {
            ListaInputs.Add(new InputModel());
        }
    }
}