namespace VetClinic.Data;
using Models;

public class VisitsRepository
{
    public static readonly List<Visit> Visits =
    [
        new() { Date = new(2024, 1, 10), Animal = AnimalsRepository.Animals[0], Description = "Vaccination", Price = 50.0 },
        new() { Date = new(2024, 1, 15), Animal = AnimalsRepository.Animals[1], Description = "Regular check-up", Price = 30.0 },
        new() { Date = new(2024, 2, 5), Animal = AnimalsRepository.Animals[2], Description = "Nail trimming", Price = 15.0 },
        new() { Date = new(2024, 2, 12), Animal = AnimalsRepository.Animals[3], Description = "Ear cleaning", Price = 25.0 },
        new() { Date = new(2024, 2, 20), Animal = AnimalsRepository.Animals[4], Description = "X-ray examination", Price = 100.0 },
        new() { Date = new(2024, 3, 3), Animal = AnimalsRepository.Animals[5], Description = "Dental cleaning", Price = 70.0 },
        new() { Date = new(2024, 3, 10), Animal = AnimalsRepository.Animals[6], Description = "Wing clipping", Price = 20.0 },
        new() { Date = new(2024, 3, 17), Animal = AnimalsRepository.Animals[7], Description = "Skin allergy treatment", Price = 60.0 },
        new() { Date = new(2024, 3, 25), Animal = AnimalsRepository.Animals[8], Description = "Microchipping", Price = 45.0 },
        new() { Date = new(2024, 4, 1), Animal = AnimalsRepository.Animals[9], Description = "Vaccination booster", Price = 50.0 },
        new() { Date = new(2024, 4, 8), Animal = AnimalsRepository.Animals[10], Description = "Post-surgery check", Price = 35.0 },
        new() { Date = new(2024, 4, 15), Animal = AnimalsRepository.Animals[11], Description = "Flea treatment", Price = 25.0 },
        new() { Date = new(2024, 4, 22), Animal = AnimalsRepository.Animals[12], Description = "Injury dressing", Price = 40.0 },
        new() { Date = new(2024, 4, 29), Animal = AnimalsRepository.Animals[13], Description = "Dental extraction", Price = 85.0 },
        new() { Date = new(2024, 5, 5), Animal = AnimalsRepository.Animals[14], Description = "Urine analysis", Price = 30.0 },
        new() { Date = new(2024, 5, 12), Animal = AnimalsRepository.Animals[15], Description = "Eye infection treatment", Price = 55.0 },
        new() { Date = new(2024, 5, 19), Animal = AnimalsRepository.Animals[16], Description = "Weight loss consultation", Price = 40.0 },
        new() { Date = new(2024, 5, 26), Animal = AnimalsRepository.Animals[17], Description = "Blood test", Price = 65.0 },
        new() { Date = new(2024, 6, 2), Animal = AnimalsRepository.Animals[18], Description = "Routine check-up", Price = 30.0 },
        new() { Date = new(2024, 6, 9), Animal = AnimalsRepository.Animals[19], Description = "Hairball treatment", Price = 25.0 }
    ];
}