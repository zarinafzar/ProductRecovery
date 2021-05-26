using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class RuntimeTasks
    {
        [Key]
        public int Id { get; set; }

        public int UnitId { get; set; }
        [ForeignKey(nameof(UnitId))]
        public virtual Units Units { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }
        public string Description { get; set; }

        [StringLength(50)]
        public string Person { get; set; }

        [StringLength(50)]
        public string ControllerPerson { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int DeleveryDays { get; set; }
        public bool IsFinish { get; set; }
        public bool IsCancel { get; set; }
    }
}
