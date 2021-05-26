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

        [StringLength(50)]
        public string UnitName { get; set; }

        public string Remark { get; set; }
        public bool IsDelete { get; set; }

        //کالکشن کلید خارجی در کتگوری
        public ICollection<Categories> Categories { get; set; }
        public ICollection<RuntimeTasks> RuntimeTasks { get; set; }
    }
}
