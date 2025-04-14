using VetClinic.Data;
using VetClinic.Models;

namespace VetClinic.Handlers;

public static class AnimalsEndpointsHandlers
{
    public static IResult GetAllAnimals() => Results.Ok(AnimalsRepository.Animals);

    public static IResult GetAnimalById(int id)
    {
        var animal = AnimalsRepository.Animals.FirstOrDefault(a => a.Id == id);
        return animal is not null ? Results.Ok(animal) : Results.NotFound();
    }

    public static IResult AddAnimal(Animal animal)
    {
        if (AnimalsRepository.Animals.Any(a => a.Id == animal.Id))
        {
            return Results.Conflict($"Animal with Id {animal.Id} already exists.");
        }
        
        AnimalsRepository.Animals.Add(animal);
        return Results.Created($"/api/animals/{animal.Id}", animal);
    }

    public static IResult UpdateAnimal(int id, Animal animal)
    {
        var existingAnimal = AnimalsRepository.Animals.FirstOrDefault(a => a.Id == id);
        if (existingAnimal is null) 
            return Results.NotFound();

        existingAnimal.Name = animal.Name;
        existingAnimal.Category = animal.Category;
        existingAnimal.Weight = animal.Weight;
        existingAnimal.FurColor = animal.FurColor;
        
        return Results.Ok(existingAnimal);
    }

    public static IResult DeleteAnimal(int id)
    {
        var existingAnimal = AnimalsRepository.Animals.FirstOrDefault(a => a.Id == id);

        if (existingAnimal is null)
            return Results.NotFound();
        
        AnimalsRepository.Animals.Remove(existingAnimal);
        return Results.NoContent();
    }
}