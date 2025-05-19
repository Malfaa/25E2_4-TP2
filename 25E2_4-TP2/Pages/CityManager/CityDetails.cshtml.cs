using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _25E2_4_TP2.Pages.CityManager;

public class CityDetails : PageModel
{
    public string CityName { get; set; }
    public List<String> Cities = ["Rio", "São Paulo", "Brasilia"];
    
    public void OnGet(string cityName)
    {
        CityName = cityName;
    }
}