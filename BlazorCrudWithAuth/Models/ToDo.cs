using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrudWithAuth.Models
{
    public class ToDo
    {   
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Task name is required")]
        [StringLength(15, ErrorMessage = "Name is too long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Due date is required")]
        public DateTime DueDate { get; set; }
    }
}
