using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission8_Team0413.Models;

public class Task //Creates schema and required attributes for database
{
    [Key]
    [Required]
    public int TaskId { get; set; }
    
    [Required(ErrorMessage = "Please enter a task.")]
    public string TaskDescription { get; set; }
    
    public DateTime DueDate { get; set; }
    
    [Required(ErrorMessage = "Please enter a quadrant.")]
    [Range(1, 4, ErrorMessage = "Quadrant must be between 1 and 4.")]
    public int Quadrant { get; set; }
    
  [Required(ErrorMessage = "Please enter a Category.")]
    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")] //Connects separate table via Foreign Key
    public Category Category { get; set; }
    
    public bool Completed { get; set; }

}