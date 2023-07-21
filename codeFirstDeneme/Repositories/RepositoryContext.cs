using codeFirstDeneme.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace codeFirstDeneme.Repositories
{
    public class RepositoryContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }
        public Microsoft.EntityFrameworkCore.DbSet<Book> Books { get; set; }
    }
}
