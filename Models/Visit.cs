namespace VetClinic.Models;

public class Visit
{
    public required DateTime Date { get; set; }
    public required Animal Animal { get; set; }
    public required string Description { get; set; }
    public required double Price { get; set; }
}