namespace playgorund.api.Dtos;

public record class EventDto(
    int Id, 
    string Title,
    string Description,
    string ImageUrl,
    Decimal Price,
    DateOnly Date
);