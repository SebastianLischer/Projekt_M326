using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_M326.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=M326ConnectionString")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Competence> Competences { get; set; }
        public DbSet<CompetenceGrid> CompetenceGrids { get; set; }
        public DbSet<CompetenceGridCompentence> CompetenceGridCompetences { get; set; }
        }
}
