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

    public class InputModel 
    {
        [Required(ErrorMessage = "Nome necessário")]
        public string CountryName { set; get; }
        [Required(ErrorMessage = "Código necessário")]
        [StringLength(2, MinimumLength = 2)]
        public string CountryCode { set; get; }
    }

    public void OnPost()
    {
        for (int i = 0; i < ListaInputs.Count; i++)
        {
            if (!string.IsNullOrEmpty(ListaInputs[i].CountryName) && 
                !string.IsNullOrEmpty(ListaInputs[i].CountryCode))
            {
                var firstLetterName = ListaInputs[i].CountryName.Substring(0, 1).ToUpper();
                var firstLetterCode = ListaInputs[i].CountryCode.Substring(0, 1).ToUpper();
                
                if (firstLetterName != firstLetterCode)
                {
                    ModelState.AddModelError($"ListaInputs[{i}].CountryCode", 
                        $"A primeira letra do código deve ser igual à primeira letra do nome do país.");
                }
            }
        }

        if (ModelState.IsValid)
        {
            foreach (var input in ListaInputs)
            {
                if (!string.IsNullOrEmpty(input.CountryName) && !string.IsNullOrEmpty(input.CountryCode))
                {
                    var country = Country.FromInputModel(input);
                    Console.WriteLine($"Nome país: {country.CountryName}\nCódigo país: {country.CountryCode}");
                }
            }
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