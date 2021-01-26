using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SpeakerApp.Models
{
    public class Speaker
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string SpeakerName { get; set; }

        [Required]
        [StringLength(100)]
        public string Qualification { get; set; }

        [Required]
        [StringLength(100)]
        public int Experience { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime SpeakingDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Time")]
        public DateTime SpeakingTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }
        
        [Display(Name = "Image")]
        public string ProfilePicture { get; set; }
    }
}
