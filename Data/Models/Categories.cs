using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Categories
    {
        [Key] 
        public int Id { get; set; }

        [StringLength(50)]
        public string CatName { get; set; }

        public string Remark { get; set; }
        public bool IsDelete { get; set; }


        //کلید خارجی با یونیت
        public int UnitId { get; set; }
        [ForeignKey(nameof(UnitId))] 
        public virtual Units Units { get; set; }

    }
}
