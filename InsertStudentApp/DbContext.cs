using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace InsertStudentApp
{
    public class StudentDB1Entities : DbContext
    {
        public StudentDB1Entities() : base("name=StudentDB1Entities") { }

        public DbSet<stTable> stTables { get; set; }
    }
}
