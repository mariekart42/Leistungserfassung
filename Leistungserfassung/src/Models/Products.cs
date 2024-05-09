using System.ComponentModel.DataAnnotations.Schema;

namespace Leistungserfassung.Models;

public class Products
{
    public int Id { get; set; }

    // initializing name to null but telling compiler that it won't be null during runtime
    public string Name { get; set; } = null!;
    
    // comes from System.ComponentModel.DataAnnotations.Schema and allows to specify additional metadata to the column
    // precision of 6 digits and a scale of 2 digits after the decimal point
    [Column(TypeName = "decimal(6, 2)")]
    public decimal Price { get; set; }
}