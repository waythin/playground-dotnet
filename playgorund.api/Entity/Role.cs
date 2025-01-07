using System;

namespace playgorund.api.Entity;

public class Role
{
    public int ID { get; set; }

    public required string Name { get; set; }

    public  string? Description { get; set; }

    public DateTime CreatedAt { get; set; }
}
