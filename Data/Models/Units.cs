using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Units
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string UnitName { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Remark { get; set; }
        public bool IsDelete { get; set; }
    }
}
