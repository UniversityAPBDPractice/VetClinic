using VetClinic.Handlers;

namespace VetClinic.Endpoints;

public static class VisitsEndpoints
{
    public static RouteGroupBuilder MapVisitsEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/visits");

        routes.MapGet("/api/animals/{id:int}/visits", VisitsEndpointsHandlers.GetVisitsByAnimalId);
        routes.MapPost("", VisitsEndpointsHandlers.AddVisit);
        
        return group;
    }
}