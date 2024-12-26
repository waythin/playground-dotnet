namespace playgorund.api.Dtos;

public record class UpdateEventDto(
    string Title,
    string Description,
    string ImageUrl,
    Decimal Price,
    DateOnly Date
);