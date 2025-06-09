using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UFSEstates.Models
{
    public class Complaint
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "The complainant field is required.")]
        public string Complainant { get; set; }
        [Required(ErrorMessage = "The Service field is required.")]
        public string Service { get; set; }
        [Required(ErrorMessage = "Please eneter the description.")]
        [StringLength(100,ErrorMessage = "The decription must have 50 to 100 characters.", MinimumLength = 50)]
        public string Description { get; set; }
        [Required]
        [DisplayName("Date of complaint")]
        public DateTime DateOfComplaint { get; set; }=DateTime.Now;
    }
}
