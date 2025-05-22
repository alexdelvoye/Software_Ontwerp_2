namespace WeerEventsApi.Facade.Dto;

public class MetingDto
{
    public required DateTime MomentMeting { get; set; }
    public required double Waarde { get; set; }
    public required string Eenheid { get; set; }
    public required string StadNaam { get; set; }
}