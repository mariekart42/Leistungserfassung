namespace Leistungserfassung.Models;

public class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;
    
    public string LastName { get; set; } = null!;
    
    public string? Email { get; set; }

    // field CAN be null
    public string? Address { get; set; }
    
    public string? Phone { get; set; }

    // single to many relation
    public ICollection<Order> Orders { get; set; } = null!;
}