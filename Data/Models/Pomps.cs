using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Pomps
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string PompName { get; set; }

        [StringLength(50)]
        public string  PompType { get; set; }
        public string Remark { get; set; }
        public int InWorkDuration { get; set; }
        public bool IsDelete { get; set; }

        public int CatId { get; set; }
        [ForeignKey(nameof(CatId))] 
        public virtual Categories Categories { get; set; }
    }
}
