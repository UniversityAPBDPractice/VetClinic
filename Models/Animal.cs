namespace VetClinic.Models;

public class Animal
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required AnimalType Category { get; set; }
    public required double Weight { get; set; }
    public required Color FurColor { get; set; }
}