using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakerApp.Models
{
    public class EditImageViewModel: UploadImageViewModel
    {
        public int Id { get; set; }
        public string ExistingImage { get; set; }
    }
}
