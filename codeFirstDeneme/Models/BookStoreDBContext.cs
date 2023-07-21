using System.Data.Entity;
using System.Data.SqlClient ;

namespace codeFirstDeneme.Models
{
    public class codeFirstDenemeDBContext : DbContext 
    {
        public DbSet<Book> Books { get; set; }
    }
}
