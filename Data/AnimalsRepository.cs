namespace VetClinic.Data;
using Models;

public class AnimalsRepository
{
    public static readonly List<Animal> Animals =
    [
        new() { Id = 1, Name = "Bella", Category = AnimalType.Dog, Weight = 12.5, FurColor = Color.Ginger },
        new() { Id = 2, Name = "Max", Category = AnimalType.Cat, Weight = 4.2, FurColor = Color.Black },
        new() { Id = 3, Name = "Luna", Category = AnimalType.Rabbit, Weight = 1.8, FurColor = Color.White },
        new() { Id = 4, Name = "Charlie", Category = AnimalType.Dog, Weight = 10.1, FurColor = Color.Black },
        new() { Id = 5, Name = "Lucy", Category = AnimalType.Cat, Weight = 3.9, FurColor = Color.Ginger },
        new() { Id = 6, Name = "Daisy", Category = AnimalType.Dog, Weight = 14.3, FurColor = Color.White },
        new() { Id = 7, Name = "Milo", Category = AnimalType.Parrot, Weight = 0.9, FurColor = Color.Red },
        new() { Id = 8, Name = "Bailey", Category = AnimalType.Dog, Weight = 11.0, FurColor = Color.Ginger },
        new() { Id = 9, Name = "Zoe", Category = AnimalType.Cat, Weight = 4.1, FurColor = Color.Black },
        new() { Id = 10, Name = "Rocky", Category = AnimalType.Rabbit, Weight = 2.3, FurColor = Color.White },
        new() { Id = 11, Name = "Coco", Category = AnimalType.Dog, Weight = 13.4, FurColor = Color.Red },
        new() { Id = 12, Name = "Oliver", Category = AnimalType.Cat, Weight = 3.5, FurColor = Color.White },
        new() { Id = 13, Name = "Nala", Category = AnimalType.Rabbit, Weight = 1.7, FurColor = Color.Ginger },
        new() { Id = 14, Name = "Teddy", Category = AnimalType.Dog, Weight = 15.6, FurColor = Color.Black },
        new() { Id = 15, Name = "Lily", Category = AnimalType.Cat, Weight = 3.2, FurColor = Color.Red },
        new() { Id = 16, Name = "Buddy", Category = AnimalType.Dog, Weight = 12.0, FurColor = Color.White },
        new() { Id = 17, Name = "Simba", Category = AnimalType.Cat, Weight = 4.4, FurColor = Color.Ginger },
        new() { Id = 18, Name = "Pepper", Category = AnimalType.Parrot, Weight = 0.8, FurColor = Color.Black },
        new() { Id = 19, Name = "Ruby", Category = AnimalType.Dog, Weight = 13.1, FurColor = Color.Red },
        new() { Id = 20, Name = "Ginger", Category = AnimalType.Cat, Weight = 3.6, FurColor = Color.White }
    ];
}