using VetClinic.Data;
using VetClinic.Models;

namespace VetClinic.Handlers;

public static class VisitsEndpointsHandlers
{
    public static IResult GetVisitsByAnimalId(int id)
    {
        var visits = VisitsRepository.Visits
            .Where(v => v.Animal.Id == id)
            .ToList();
        
        return visits.Count != 0 ? Results.Ok(visits) : Results.NotFound();
    }

    public static IResult AddVisit(Visit visit)
    {
        VisitsRepository.Visits.Add(visit);
        return Results.Created($"/api/visits/{visit.Animal.Id}", visit);
    }
}