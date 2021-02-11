using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JeugdApp.Entities
{
    public class Activity
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Organizer { get; set; }

        public string Guide { get; set; }

        public int Attendance { get; set; }

        public DateTime Date { get; set; }
    }
}
