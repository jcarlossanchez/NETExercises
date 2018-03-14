using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace RazorExercise.Models
{
    public class FileUpload
    {
        [Required]
        [Display(Name = "Titulo")]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Horario Publico")]
        public IFormFile UploadPublicSchedule { get; set; }

        [Required]
        [Display(Name = "Horario Privado")]
        public IFormFile UploadPrivateSchedule { get; set; }
    }
}
