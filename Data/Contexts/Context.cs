using System;
using System.Data.Entity;
using System.Linq;
using Data.Models;

namespace Data.Contexts
{
    public class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Pomps> Pomps { get; set; }
        public virtual DbSet<PompsEvents> PompsEvents { get; set; }
        
    }
   
}