namespace JWT_Basic_Implementation.DTO;

public class WeatherDTO
{
    public WeatherDTO(DateTime date, string location, double temperature, double humidity)
    {
        Date = date;
        Location = location;
        Temperature = temperature;
        Humidity = humidity;
    }

    public WeatherDTO(){}

    public DateTime Date { get; set; }
    public string Location { get; set; }
    public double Temperature { get; set; }
    public double Humidity { get; set; }
}