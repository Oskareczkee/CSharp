using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Language_Learning_App.DB.Models
{
    public class Session
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ID { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
        public int? WordsTranslated { get; set; } = 0;
        public int? Successes { get; set; } = 0;
        public int? Fails { get; set; } = 0;

        public int? UserID { get; set; }
        public User User { get; set; } = null!;
    }
}
