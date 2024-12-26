using System.ComponentModel.DataAnnotations;

namespace playgorund.api.Dtos;

public record class CreateEventDto(
    [Required][StringLength(20)] string Title,
    [Required][StringLength(20)]string Description,
    string ImageUrl,
    [Required][Range(1, 100000000)]Decimal Price,
    DateOnly Date
);
