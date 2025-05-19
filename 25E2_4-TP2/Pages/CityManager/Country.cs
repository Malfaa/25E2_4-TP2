namespace _25E2_4_TP2.Pages.CityManager;

public class Country
{
    public string CountryName { set; get; }
    public string CountryCode { set; get; }

    public static Country FromInputModel(CreateCountry.InputModel input)
    {
        return new Country
        {
            CountryName = input.CountryName, 
            CountryCode = input.CountryCode
        };
    }
}