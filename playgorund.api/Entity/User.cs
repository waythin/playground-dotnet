using System;
using SQLitePCL;

namespace playgorund.api.Entity;

public class User
{
    public int ID { get; set; }

    public required string FirstName { get; set; }

    public required string Email { get; set; }

    public string? Phone { get; set; }

    public int RoleId { get; set; }

    public Role? Role { get; set; }
}
