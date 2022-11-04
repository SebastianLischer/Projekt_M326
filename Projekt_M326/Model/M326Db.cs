using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_M326.Model
{
    public class M326Db : DbContext
    {
        public M326Db() : base("name=M326ConnectionString") { }

        public DbSet<User> Users { get; set; }
    }
}
