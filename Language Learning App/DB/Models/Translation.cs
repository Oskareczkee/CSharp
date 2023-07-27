using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Language_Learning_App.DB.Models
{
    public class Translation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public int? ID { get; set; }
        public string WordToTranslate { get; set; } = string.Empty;
        public string WordTranslation { get; set; } = string.Empty;
        public Language Language { get; set; }

        [JsonIgnore]
        public bool Completed { get; set; } = false;
    }
}
