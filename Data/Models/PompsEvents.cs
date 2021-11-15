using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class PompsEvents
    {
        [Key]
        public int Id { get; set; }
        public int PompId { get; set; }
        [ForeignKey(nameof(PompId))] 
        public virtual Pomps Pomps{ get; set; }

        public DateTime StartDate { get; set; }

        public DateTime StopDate { get; set; }

        public bool IsStart { get; set; }

        public string Descriptions { get; set; }
    }
}
