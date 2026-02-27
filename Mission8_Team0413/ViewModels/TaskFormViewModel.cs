using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mission8_Team0413.ViewModels
{
    public class TaskFormViewModel
    {
        public int TaskId { get; set; }

        [Required(ErrorMessage = "Please enter a task.")]
        [Display(Name = "Task")]
        public string TaskDescription { get; set; } = string.Empty;

        // Your entity's DueDate is non-nullable. Keeping it nullable in the VM
        // gives you flexibility to show an empty date in the form if desired.
        [DataType(DataType.Date)]
        [Display(Name = "Due Date")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please enter a quadrant.")]
        [Range(1, 4, ErrorMessage = "Quadrant must be between 1 and 4.")]
        public int Quadrant { get; set; }

        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

        [Display(Name = "Completed")]
        public bool Completed { get; set; }

        // Populated by controller from TaskContext.Categories
        public SelectList CategoryList { get; set; } =
            new SelectList(Array.Empty<SelectListItem>());
    }
}
