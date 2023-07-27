using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Learning_App.DB.Models
{
    public class User
    {
        public int? ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? FailCount { get; set; } = 0;
        public int? SuccessCount { get; set; } = 0;

        public IEnumerable<Session> Sessions { get; set; } = new List<Session>();
    }
}
