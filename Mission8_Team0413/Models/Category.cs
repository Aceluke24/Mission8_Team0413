using System.ComponentModel.DataAnnotations;

namespace Mission8_Team0413.Models;

public class Category //Creates separate table in database
{
    [Key]
    public int CategoryId { get; set; }
    
    public string CategoryName { get; set; }
}