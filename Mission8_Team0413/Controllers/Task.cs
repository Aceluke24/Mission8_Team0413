using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission8_Team0413.Models;

public class ProductivityTask
{
    [Key]
    [Required]
    public int ProductivityTaskId { get; set; }
    
    [Required (ErrorMessage = "Please enter the task.")]
    public string TaskDescription { get; set; }
    
    public DateTime DueDate { get; set; }
    
    [Required (ErrorMessage = "Please enter a quadrant.")]
    public int Quadrant { get; set; }
    
    public bool Completed { get; set; }
    
}