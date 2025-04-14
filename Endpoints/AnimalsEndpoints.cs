using VetClinic.Handlers;

namespace VetClinic.Endpoints;

public static class AnimalsEndpoints
{
    public static RouteGroupBuilder MapAnimalsEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/animals");

        group.MapGet("", AnimalsEndpointsHandlers.GetAllAnimals);
        group.MapGet("{id:int}", AnimalsEndpointsHandlers.GetAnimalById);
        group.MapPost("", AnimalsEndpointsHandlers.AddAnimal);
        group.MapPut("{id:int}", AnimalsEndpointsHandlers.UpdateAnimal);
        group.MapDelete("{id:int}", AnimalsEndpointsHandlers.DeleteAnimal);
        
        return group;
    }
}