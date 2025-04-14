namespace VetClinic.Data;
using Models;

public class AnimalsRepository
{
    public static readonly List<Animal> Animals =
    [
        new() { Id = 1, Name = "Bella", Category = "Dog", Weight = 12.5, FurColor = "Ginger" },
        new() { Id = 2, Name = "Max", Category = "Cat", Weight = 4.2, FurColor = "Black" },
        new() { Id = 3, Name = "Luna", Category = "Rabbit", Weight = 1.8, FurColor = "White" },
        new() { Id = 4, Name = "Charlie", Category = "Dog", Weight = 10.1, FurColor = "Black" },
        new() { Id = 5, Name = "Lucy", Category = "Cat", Weight = 3.9, FurColor = "Ginger" },
        new() { Id = 6, Name = "Daisy", Category = "Dog", Weight = 14.3, FurColor = "White" },
        new() { Id = 7, Name = "Milo", Category = "Parrot", Weight = 0.9, FurColor = "Red" },
        new() { Id = 8, Name = "Bailey", Category = "Dog", Weight = 11.0, FurColor = "Ginger" },
        new() { Id = 9, Name = "Zoe", Category = "Cat", Weight = 4.1, FurColor = "Black" },
        new() { Id = 10, Name = "Rocky", Category = "Rabbit", Weight = 2.3, FurColor = "White" },
        new() { Id = 11, Name = "Coco", Category = "Dog", Weight = 13.4, FurColor = "Red" },
        new() { Id = 12, Name = "Oliver", Category = "Cat", Weight = 3.5, FurColor = "White" },
        new() { Id = 13, Name = "Nala", Category = "Rabbit", Weight = 1.7, FurColor = "Ginger" },
        new() { Id = 14, Name = "Teddy", Category = "Dog", Weight = 15.6, FurColor = "Black" },
        new() { Id = 15, Name = "Lily", Category = "Cat", Weight = 3.2, FurColor = "Red" },
        new() { Id = 16, Name = "Buddy", Category = "Dog", Weight = 12.0, FurColor = "White" },
        new() { Id = 17, Name = "Simba", Category = "Cat", Weight = 4.4, FurColor = "Ginger" },
        new() { Id = 18, Name = "Pepper", Category = "Parrot", Weight = 0.8, FurColor = "Black" },
        new() { Id = 19, Name = "Ruby", Category = "Dog", Weight = 13.1, FurColor = "Red" },
        new() { Id = 20, Name = "Ginger", Category = "Cat", Weight = 3.6, FurColor = "White" }
    ];
}