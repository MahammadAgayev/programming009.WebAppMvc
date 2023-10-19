namespace programming009.WebAppMvc.Models
{
    public class WeatherForecastModel
    {
        public List<WeatherForecastDayModel> Days { get; set; }
    }

    public class WeatherForecastDayModel
    {
        public DateOnly Date { get; set; }
        public string Icon { get; set; }
        public double Temprature { get; set; }
    }
}
